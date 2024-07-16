﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PushedAuthorizationRequestErrorsFeature : object, Xunit.IClassFixture<PushedAuthorizationRequestErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PushedAuthorizationRequestErrors.feature"
#line hidden
        
        public PushedAuthorizationRequestErrorsFeature(PushedAuthorizationRequestErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "PushedAuthorizationRequestErrors", "\tCheck errors returned by the pushed authorization request endpoint", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Reject request with request_uri parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Reject request with request_uri parameter")]
        public void RejectRequestWithRequest_UriParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reject request with request_uri parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table435 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table435.AddRow(new string[] {
                            "request_uri",
                            "request"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table435, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.Then("JSON \'error_description\'=\'the request cannot contains request_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Response Type is required")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Response Type is required")]
        public void ResponseTypeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Response Type is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table436 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table436.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
#line 16
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table436, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.Then("JSON \'error_description\'=\'missing parameter response_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Response Type must be supported")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Response Type must be supported")]
        public void ResponseTypeMustBeSupported()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Response Type must be supported", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table437 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table437.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table437.AddRow(new string[] {
                            "response_type",
                            "invalid"});
#line 27
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table437, "When ");
#line hidden
#line 32
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.Then("JSON \'error\'=\'unsupported_response_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.Then("JSON \'error_description\'=\'missing response types invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Scope, resource or authorization_details parameter are required")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Scope, resource or authorization_details parameter are required")]
        public void ScopeResourceOrAuthorization_DetailsParameterAreRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scope, resource or authorization_details parameter are required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table438 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table438.AddRow(new string[] {
                            "response_type",
                            "code"});
                table438.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table438.AddRow(new string[] {
                            "state",
                            "state"});
                table438.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table438.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8081"});
                table438.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table438.AddRow(new string[] {
                            "display",
                            "popup"});
#line 39
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table438, "When ");
#line hidden
#line 49
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.Then("JSON \'error_description\'=\'missing parameters scope,resource,authorization_details" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Scope must be supported")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Scope must be supported")]
        public void ScopeMustBeSupported()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scope must be supported", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 55
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table439 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table439.AddRow(new string[] {
                            "response_type",
                            "code"});
                table439.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table439.AddRow(new string[] {
                            "state",
                            "state"});
                table439.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table439.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table439.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table439.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table439.AddRow(new string[] {
                            "display",
                            "popup"});
#line 56
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table439, "When ");
#line hidden
#line 66
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then("JSON \'error_description\'=\'scopes scope1 are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Redirect Uri must be valid")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Redirect Uri must be valid")]
        public void RedirectUriMustBeValid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Redirect Uri must be valid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table440 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table440.AddRow(new string[] {
                            "response_type",
                            "code"});
                table440.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table440.AddRow(new string[] {
                            "state",
                            "state"});
                table440.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table440.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table440.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8081"});
                table440.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table440.AddRow(new string[] {
                            "display",
                            "popup"});
#line 74
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table440, "When ");
#line hidden
#line 85
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.Then("JSON \'error_description\'=\'redirect_uri http://localhost:8081 is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Response Mode must be valid")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Response Mode must be valid")]
        public void ResponseModeMustBeValid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Response Mode must be valid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 91
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table441 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table441.AddRow(new string[] {
                            "response_type",
                            "code"});
                table441.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table441.AddRow(new string[] {
                            "state",
                            "state"});
                table441.AddRow(new string[] {
                            "response_mode",
                            "invalid"});
                table441.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table441.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table441.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table441.AddRow(new string[] {
                            "display",
                            "popup"});
#line 92
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table441, "When ");
#line hidden
#line 103
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.Then("JSON \'error_description\'=\'response mode invalid is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Response type must be supported by the client")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Response type must be supported by the client")]
        public void ResponseTypeMustBeSupportedByTheClient()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Response type must be supported by the client", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 109
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table442 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table442.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table442.AddRow(new string[] {
                            "client_id",
                            "fortyClient"});
                table442.AddRow(new string[] {
                            "state",
                            "state"});
                table442.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table442.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table442.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table442.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table442.AddRow(new string[] {
                            "display",
                            "popup"});
#line 110
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table442, "When ");
#line hidden
#line 121
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 124
 testRunner.Then("JSON \'error\'=\'unsupported_response_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 125
 testRunner.Then("JSON \'error_description\'=\'response types id_token are not supported by the client" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Nonce is required when id_token is present in the response_type")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "Nonce is required when id_token is present in the response_type")]
        public void NonceIsRequiredWhenId_TokenIsPresentInTheResponse_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nonce is required when id_token is present in the response_type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 127
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table443 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table443.AddRow(new string[] {
                            "response_type",
                            "code id_token"});
                table443.AddRow(new string[] {
                            "client_id",
                            "thirtyOneClient"});
                table443.AddRow(new string[] {
                            "state",
                            "state"});
                table443.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table443.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table443.AddRow(new string[] {
                            "scope",
                            "openid email"});
                table443.AddRow(new string[] {
                            "display",
                            "popup"});
#line 128
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table443, "When ");
#line hidden
#line 138
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 140
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 141
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 142
 testRunner.Then("JSON \'error_description\'=\'missing parameter nonce\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="grant_management_action parameter must be valid")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "grant_management_action parameter must be valid")]
        public void Grant_Management_ActionParameterMustBeValid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("grant_management_action parameter must be valid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 144
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table444 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table444.AddRow(new string[] {
                            "response_type",
                            "code token"});
                table444.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table444.AddRow(new string[] {
                            "state",
                            "state"});
                table444.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table444.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table444.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table444.AddRow(new string[] {
                            "claims",
                            "{ \"id_token\": { \"acr\": { \"essential\" : true, \"value\": \"urn:openbanking:psd2:ca\" }" +
                                " } }"});
                table444.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table444.AddRow(new string[] {
                            "grant_management_action",
                            "invalid"});
#line 145
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table444, "When ");
#line hidden
#line 156
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 158
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 159
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 160
 testRunner.Then("JSON \'error_description\'=\'the grant_management_action invalid is not valid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="grant_id cannot be specified when grant_management_action is equals to create")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "grant_id cannot be specified when grant_management_action is equals to create")]
        public void Grant_IdCannotBeSpecifiedWhenGrant_Management_ActionIsEqualsToCreate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("grant_id cannot be specified when grant_management_action is equals to create", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 163
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table445 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table445.AddRow(new string[] {
                            "response_type",
                            "code token"});
                table445.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table445.AddRow(new string[] {
                            "state",
                            "state"});
                table445.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table445.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table445.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table445.AddRow(new string[] {
                            "claims",
                            "{ \"id_token\": { \"acr\": { \"essential\" : true, \"value\": \"urn:openbanking:psd2:ca\" }" +
                                " } }"});
                table445.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table445.AddRow(new string[] {
                            "grant_management_action",
                            "create"});
                table445.AddRow(new string[] {
                            "grant_id",
                            "id"});
#line 164
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table445, "When ");
#line hidden
#line 176
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 178
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 179
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 180
 testRunner.Then("JSON \'error_description\'=\'grant_id cannot be specified because the grant_manageme" +
                        "nt_action is equals to create\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="grant_management_action must be specified when grant_id is present")]
        [Xunit.TraitAttribute("FeatureTitle", "PushedAuthorizationRequestErrors")]
        [Xunit.TraitAttribute("Description", "grant_management_action must be specified when grant_id is present")]
        public void Grant_Management_ActionMustBeSpecifiedWhenGrant_IdIsPresent()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("grant_management_action must be specified when grant_id is present", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 182
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table446 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table446.AddRow(new string[] {
                            "response_type",
                            "code token"});
                table446.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table446.AddRow(new string[] {
                            "state",
                            "state"});
                table446.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table446.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table446.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table446.AddRow(new string[] {
                            "claims",
                            "{ \"id_token\": { \"acr\": { \"essential\" : true, \"value\": \"urn:openbanking:psd2:ca\" }" +
                                " } }"});
                table446.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table446.AddRow(new string[] {
                            "grant_id",
                            "id"});
#line 183
 testRunner.When("execute HTTP POST request \'https://localhost:8080/par\'", ((string)(null)), table446, "When ");
#line hidden
#line 194
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 196
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 197
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 198
 testRunner.Then("JSON \'error_description\'=\'missing parameter grant_management_action\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PushedAuthorizationRequestErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PushedAuthorizationRequestErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
