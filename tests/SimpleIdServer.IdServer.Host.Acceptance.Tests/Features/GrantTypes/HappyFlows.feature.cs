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
    public partial class HappyFlowsFeature : object, Xunit.IClassFixture<HappyFlowsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "HappyFlows.feature"
#line hidden
        
        public HappyFlowsFeature(HappyFlowsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "HappyFlows", "\tRun happy flows for all the grant types", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Use \'client_credentials\' grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "HappyFlows")]
        [Xunit.TraitAttribute("Description", "Use \'client_credentials\' grant type to get an access token")]
        public void UseClient_CredentialsGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use \'client_credentials\' grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table126 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table126.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table126.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table126.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table126.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table126, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.And("JSON \'$.scope\'=\'firstScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("JSON \'$.token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("JSON \'$.expires_in\'=\'1800\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("access_token audience contains \'firstClient\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("access_token audience contains \'secondClient\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("access_token scope contains \'firstScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("access_token alg equals to \'RS256\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("access_token kid equals to \'keyid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use \'password\' grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "HappyFlows")]
        [Xunit.TraitAttribute("Description", "Use \'password\' grant type to get an access token")]
        public void UsePasswordGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use \'password\' grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table127 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table127.AddRow(new string[] {
                            "client_id",
                            "secondClient"});
                table127.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table127.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table127.AddRow(new string[] {
                            "grant_type",
                            "password"});
                table127.AddRow(new string[] {
                            "username",
                            "user"});
                table127.AddRow(new string[] {
                            "password",
                            "password"});
#line 25
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table127, "When ");
#line hidden
#line 34
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.And("JSON \'$.scope\'=\'firstScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("JSON \'$.token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("JSON \'$.expires_in\'=\'1800\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("access_token audience contains \'firstClient\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("access_token audience contains \'secondClient\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("access_token scope contains \'firstScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("access_token alg equals to \'RS256\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("access_token kid equals to \'keyid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use \'authorization_code\' grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "HappyFlows")]
        [Xunit.TraitAttribute("Description", "Use \'authorization_code\' grant type to get an access token")]
        public void UseAuthorization_CodeGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use \'authorization_code\' grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table128 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table128.AddRow(new string[] {
                            "response_type",
                            "code"});
                table128.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table128.AddRow(new string[] {
                            "state",
                            "state"});
                table128.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table128.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table128.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 48
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table128, "When ");
#line hidden
#line 57
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("extract parameter \'state\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table129 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table129.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table129.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table129.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table129.AddRow(new string[] {
                            "code",
                            "$code$"});
                table129.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 60
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table129, "And ");
#line hidden
#line 68
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And("JSON \'$.scope\'=\'secondScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("JSON \'$.token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("JSON \'$.expires_in\'=\'1800\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("parameter \'state\'=\'state\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Use \'refresh_token\' grant type to get an access token")]
        [Xunit.TraitAttribute("FeatureTitle", "HappyFlows")]
        [Xunit.TraitAttribute("Description", "Use \'refresh_token\' grant type to get an access token")]
        public void UseRefresh_TokenGrantTypeToGetAnAccessToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use \'refresh_token\' grant type to get an access token", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table130 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table130.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table130.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table130.AddRow(new string[] {
                            "client_id",
                            "sixClient"});
                table130.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 77
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table130, "When ");
#line hidden
#line 84
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("extract parameter \'$.refresh_token\' from JSON body into \'refreshToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table131 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table131.AddRow(new string[] {
                            "grant_type",
                            "refresh_token"});
                table131.AddRow(new string[] {
                            "refresh_token",
                            "$refreshToken$"});
                table131.AddRow(new string[] {
                            "client_id",
                            "sixClient"});
                table131.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 87
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table131, "And ");
#line hidden
#line 94
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.And("JSON \'$.scope\'=\'secondScope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("JSON \'$.token_type\'=\'Bearer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("JSON \'$.expires_in\'=\'1800\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                HappyFlowsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                HappyFlowsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
