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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TokenExchangePreAuthorizedCodeErrorsFeature : object, Xunit.IClassFixture<TokenExchangePreAuthorizedCodeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "TokenExchangePreAuthorizedCodeErrors.feature"
#line hidden
        
        public TokenExchangePreAuthorizedCodeErrorsFeature(TokenExchangePreAuthorizedCodeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "TokenExchangePreAuthorizedCodeErrors", "\tCheck errors returned when using \'urn:ietf:params:oauth:grant-type:exchange-pre-" +
                    "authorized_code\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="client_id is required")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "client_id is required")]
        public void Client_IdIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client_id is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table362 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table362.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table362, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'missing client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="client must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "client must exists")]
        public void ClientMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table363 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table363.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table363.AddRow(new string[] {
                            "client_id",
                            "invalid"});
#line 15
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table363, "When ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("JSON \'$.error_description\'=\'unknown client invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="client must supports the grant-type")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "client must supports the grant-type")]
        public void ClientMustSupportsTheGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client must supports the grant-type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table364 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table364.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table364.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table364.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 26
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table364, "When ");
#line hidden
#line 32
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("JSON \'$.error_description\'=\'grant type urn:ietf:params:oauth:grant-type:exchange-" +
                        "pre-authorized_code is not supported by the client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="subject_token is required")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "subject_token is required")]
        public void Subject_TokenIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("subject_token is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table365 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table365.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table365.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table365.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 38
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table365, "When ");
#line hidden
#line 44
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("JSON \'$.error_description\'=\'missing parameter subject_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="subject_token_type is required")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "subject_token_type is required")]
        public void Subject_Token_TypeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("subject_token_type is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table366 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table366.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table366.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table366.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table366.AddRow(new string[] {
                            "subject_token",
                            "sub"});
#line 50
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table366, "When ");
#line hidden
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("JSON \'$.error_description\'=\'missing parameter subject_token_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="scope is required")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "scope is required")]
        public void ScopeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scope is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table367 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table367.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table367.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table367.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table367.AddRow(new string[] {
                            "subject_token",
                            "sub"});
                table367.AddRow(new string[] {
                            "subject_token_type",
                            "type"});
#line 63
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table367, "When ");
#line hidden
#line 71
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("JSON \'$.error_description\'=\'missing parameter scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="subject_token_type must be supported")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "subject_token_type must be supported")]
        public void Subject_Token_TypeMustBeSupported()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("subject_token_type must be supported", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 76
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table368 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table368.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table368.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table368.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table368.AddRow(new string[] {
                            "subject_token",
                            "sub"});
                table368.AddRow(new string[] {
                            "subject_token_type",
                            "type"});
                table368.AddRow(new string[] {
                            "scope",
                            "Credential"});
#line 77
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table368, "When ");
#line hidden
#line 86
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And("JSON \'$.error_description\'=\'the token type type is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Subject cannot be extracted from the subject_token")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "Subject cannot be extracted from the subject_token")]
        public void SubjectCannotBeExtractedFromTheSubject_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subject cannot be extracted from the subject_token", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table369 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table369.AddRow(new string[] {
                            "key",
                            "value"});
#line 92
 testRunner.Given("build access_token and sign with the key \'keyid\'", ((string)(null)), table369, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table370 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table370.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table370.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table370.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table370.AddRow(new string[] {
                            "subject_token",
                            "$access_token$"});
                table370.AddRow(new string[] {
                            "subject_token_type",
                            "type"});
                table370.AddRow(new string[] {
                            "scope",
                            "Credential"});
#line 96
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table370, "When ");
#line hidden
#line 105
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
 testRunner.And("JSON \'$.error_description\'=\'the token type type is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Scopes must be supported")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "Scopes must be supported")]
        public void ScopesMustBeSupported()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scopes must be supported", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 110
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table371 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table371.AddRow(new string[] {
                            "sub",
                            "user"});
                table371.AddRow(new string[] {
                            "client_id",
                            "client"});
#line 111
 testRunner.Given("build access_token and sign with the key \'keyid\'", ((string)(null)), table371, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table372 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table372.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table372.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table372.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table372.AddRow(new string[] {
                            "subject_token",
                            "$access_token$"});
                table372.AddRow(new string[] {
                            "subject_token_type",
                            "urn:ietf:params:oauth:token-type:access_token"});
                table372.AddRow(new string[] {
                            "scope",
                            "Credential"});
#line 116
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table372, "When ");
#line hidden
#line 125
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 126
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.And("JSON \'$.error\'=\'invalid_scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.And("JSON \'$.error_description\'=\'unknown scope Credential\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User must have an active OTP")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangePreAuthorizedCodeErrors")]
        [Xunit.TraitAttribute("Description", "User must have an active OTP")]
        public void UserMustHaveAnActiveOTP()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User must have an active OTP", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 130
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table373 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table373.AddRow(new string[] {
                            "sub",
                            "user"});
#line 131
 testRunner.Given("build access_token and sign with the key \'keyid\'", ((string)(null)), table373, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table374 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table374.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:exchange-pre-authorized_code"});
                table374.AddRow(new string[] {
                            "client_id",
                            "seventyTwoClient"});
                table374.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table374.AddRow(new string[] {
                            "subject_token",
                            "$access_token$"});
                table374.AddRow(new string[] {
                            "subject_token_type",
                            "urn:ietf:params:oauth:token-type:access_token"});
                table374.AddRow(new string[] {
                            "scope",
                            "UniversityCredential"});
#line 135
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table374, "When ");
#line hidden
#line 144
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 146
 testRunner.And("JSON \'$.error\'=\'no_active_otp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 147
 testRunner.And("JSON \'$.error_description\'=\'the user doesn\'t have an active OTP\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                TokenExchangePreAuthorizedCodeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TokenExchangePreAuthorizedCodeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
