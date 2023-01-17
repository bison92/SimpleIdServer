﻿Feature: AuthorizationErrors
	Check errors returned by the authorization endpoint

Scenario: Check redirect_uri is valid
	Given authenticate a user
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | fortyClient           |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email role     |
	| redirect_uri  | http://localhost:8081 |
	| nonce         | nonce                 |
	| display       | popup                 |	
	
	And extract JSON from body
	
	Then HTTP status code equals to '400'
	Then JSON 'error'='invalid_request'
	Then JSON 'error_description'='redirect_uri http://localhost:8081 is not correct'
	Then JSON 'state'='state'

Scenario: Scope or resource parameter are required
	Given authenticate a user
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | fortyClient           |
	| state         | state                 |
	| response_mode | query                 |
	| redirect_uri  | http://localhost:8081 |
	| nonce         | nonce                 |
	| display       | popup                 |	
	
	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='missing parameters scope,resource'

Scenario: Scope must be supported
	Given authenticate a user
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | fortyClient           |
	| state         | state                 |
	| response_mode | query                 |
	| redirect_uri  | http://localhost:8080 |
	| scope         | scope1                |
	| nonce         | nonce                 |
	| display       | popup                 |
	
	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='scopes scope1 are not supported'

Scenario: Nonce is required when id_token is present in the response_type
	Given authenticate a user
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code id_token         |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| redirect_uri  | http://localhost:8080 |
	| scope         | openid email          |
	| display       | popup                 |
	
	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='missing parameter nonce'

Scenario: Redirect Uri is required
	Given authenticate a user
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value           |
	| response_type | code            |
	| client_id     | thirtyOneClient |
	| state         | state           |
	| response_mode | query           |
	| scope         | openid email    |
	| display       | popup           |
	| nonce         | nonce           |

	And extract JSON from body
	
	Then JSON 'error'='invalid_request'
	Then JSON 'error_description'='missing parameter redirect_uri'

Scenario: User must be authenticated when prompt parameter is equals to none
	When disconnect the user
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| prompt        | none                  |
	
	Then redirection url contains the parameter value 'error'='login_required'
	Then redirection url contains the parameter value 'error_description'='login is required'

Scenario: Subject in id_token_hint must be valid
	Given authenticate a user
	And build JWS id_token_hint and sign with the key 'keyid'
	| Key | Value     |
	| sub | otheruser |
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| id_token_hint | $id_token_hint$       |

	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='subject contained in id_token_hint is invalid'

Scenario: Audience in the id_token_hint must be valid
	Given authenticate a user
	And build JWS id_token_hint and sign with the key 'keyid'
	| Key | Value     |
	| sub | user      |
	| aud | aud1 aud2 |
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| id_token_hint | $id_token_hint$       |

	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='audience contained in id_token_hint is invalid'

Scenario: Value of a sub essential claim must be valid
	Given authenticate a user
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                                                                 |
	| response_type | code                                                                  |
	| client_id     | thirtyOneClient                                                       |
	| state         | state                                                                 |
	| response_mode | query                                                                 |
	| scope         | openid email                                                          |
	| redirect_uri  | http://localhost:8080                                                 |
	| display       | popup                                                                 |
	| nonce         | nonce                                                                 |
	| claims        | { "id_token": { "sub": { "essential" : true, "value": "invalid" } } } |

	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='claims sub are invalid'

Scenario: request parameter must be a valid JWT token
	Given authenticate a user	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| request       | invalid               |

	Then redirection url contains the parameter value 'error'='invalid_request'
	Then redirection url contains the parameter value 'error_description'='request parameter is not a valid JWS token'

Scenario: request parameter must contains response_type
	Given authenticate a user	
	And build JWS request object for client 'thirtyOneClient' and sign with the key 'keyId'
	| Key   | Value |
	| claim | value |

	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| request       | $request$             |

	Then redirection url contains the parameter value 'error'='invalid_request_object'
	Then redirection url contains the parameter value 'error_description'='the response_type claim is missing'	

Scenario: request parameter must contains client_id
	Given authenticate a user	
	And build JWS request object for client 'thirtyOneClient' and sign with the key 'keyId'
	| Key           | Value |
	| response_type | code  |

	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| request       | $request$             |

	Then redirection url contains the parameter value 'error'='invalid_request_object'
	Then redirection url contains the parameter value 'error_description'='the client_id claim is missing'

Scenario: the response_type in the request parameter must be equals to the parameter passed in the HTTP request
	Given authenticate a user	
	And build JWS request object for client 'thirtyOneClient' and sign with the key 'keyId'
	| Key           | Value         |
	| response_type | code id_token |
	| client_id     | clientId      |

	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| request       | $request$             |

	Then redirection url contains the parameter value 'error'='invalid_request_object'
	Then redirection url contains the parameter value 'error_description'='the response_type claim is invalid'

Scenario: the client_id in the request parameter must be equals to the parameter passed in the HTTP request
	Given authenticate a user	
	And build JWS request object for client 'thirtyOneClient' and sign with the key 'keyId'
	| Key           | Value         |
	| response_type | code          |
	| client_id     | otherclientId |

	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid email          |
	| redirect_uri  | http://localhost:8080 |
	| display       | popup                 |
	| nonce         | nonce                 |
	| request       | $request$             |

	Then redirection url contains the parameter value 'error'='invalid_request_object'
	Then redirection url contains the parameter value 'error_description'='the client_id claim is invalid'

Scenario: redirect_uri must be valid
	Given authenticate a user	

	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value           |
	| response_type | code            |
	| client_id     | thirtyOneClient |
	| state         | state           |
	| response_mode | query           |
	| scope         | openid email    |
	| redirect_uri  | uri             |
	| display       | popup           |
	| nonce         | nonce           |

	And extract JSON from body

	Then JSON 'error'='invalid_request'
	Then JSON 'error_description'='redirect_uri uri is not correct'

Scenario: redirect to the login page when prompt is equals to login and the user is authenticated
	Given authenticate a user
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid                |
	| redirect_uri  | http://localhost:8080 |
	| nonce         | nonce                 |
	| prompt        | login                 |
		
	Then redirection url contains 'http://localhost/pwd/Authenticate'

Scenario: redirect to the account page when prompt is equals to select_account and the user is authenticated
	Given authenticate a user
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                 |
	| response_type | code                  |
	| client_id     | thirtyOneClient       |
	| state         | state                 |
	| response_mode | query                 |
	| scope         | openid                |
	| redirect_uri  | http://localhost:8080 |
	| nonce         | nonce                 |
	| prompt        | select_account        |
		
	Then redirection url contains 'http://localhost/Accounts'

Scenario: redirect to the consent page when no consent has been given to the specified claim
	Given authenticate a user
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                                              |
	| response_type | code                                               |
	| client_id     | thirtyOneClient                                    |
	| state         | state                                              |
	| response_mode | query                                              |
	| scope         | openid                                             |
	| redirect_uri  | http://localhost:8080                              |
	| nonce         | nonce                                              |
	| claims        | { "id_token": { "name": { "essential" : true } } } |

	Then redirection url contains 'http://localhost/Consents'	

Scenario: the acr value passed in the claims parameter must be valid
	When disconnect the user
	
	And execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                                                                                 |
	| response_type | code                                                                                  |
	| client_id     | thirtyOneClient                                                                       |
	| state         | state                                                                                 |
	| response_mode | query                                                                                 |
	| scope         | openid                                                                                |
	| redirect_uri  | http://localhost:8080                                                                 |
	| nonce         | nonce                                                                                 |
	| claims        | { "id_token": { "acr": { "essential" : true, "value": "urn:openbanking:psd2:ca" } } } |
	
	Then redirection url contains the parameter value 'error'='access_denied'
	Then redirection url contains the parameter value 'error_description'='no essential acr is supported'

Scenario: resource parameter is required when the client is excepting to receive this parameter
	Given authenticate a user
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                                                                                 |
	| response_type | code                                                                                  |
	| client_id     | fortySixClient                                                                        |
	| state         | state                                                                                 |
	| response_mode | query                                                                                 |
	| redirect_uri  | http://localhost:8080                                                                 |
	| nonce         | nonce                                                                                 |
	| claims        | { "id_token": { "acr": { "essential" : true, "value": "urn:openbanking:psd2:ca" } } } |
	| scope         | admin                                                                                 |
	
	Then redirection url contains the parameter value 'error'='invalid_target'
	Then redirection url contains the parameter value 'error_description'='missing parameter resource'

Scenario: resource parameter must be valid
	Given authenticate a user
	
	When execute HTTP GET request 'http://localhost/authorization'
	| Key           | Value                                                                                 |
	| response_type | code token                                                                            |
	| client_id     | fortySixClient                                                                        |
	| state         | state                                                                                 |
	| response_mode | query                                                                                 |
	| redirect_uri  | http://localhost:8080                                                                 |
	| nonce         | nonce                                                                                 |
	| claims        | { "id_token": { "acr": { "essential" : true, "value": "urn:openbanking:psd2:ca" } } } |
	| resource      | invalid                                                                               |
	| resource      | sinvalid                                                                              |
	
	Then redirection url contains the parameter value 'error'='invalid_target'
	Then redirection url contains the parameter value 'error_description'='following resources invalid,sinvalid doesn't exist'