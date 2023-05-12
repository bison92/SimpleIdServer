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
    public partial class UsersFeature : object, Xunit.IClassFixture<UsersFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Users.feature"
#line hidden
        
        public UsersFeature(UsersFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Users", "\tCheck result returned by the /users endpoint", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="create a user")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "create a user")]
        public void CreateAUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("create a user", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table479 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table479.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table479.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table479.AddRow(new string[] {
                            "scope",
                            "users"});
                table479.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table479, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table480 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table480.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table480.AddRow(new string[] {
                            "name",
                            "newUser"});
#line 15
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table480, "And ");
#line hidden
#line 20
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("JSON \'$.name\'=\'newUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="get a user")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "get a user")]
        public void GetAUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get a user", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table481 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table481.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table481.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table481.AddRow(new string[] {
                            "scope",
                            "users"});
                table481.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 26
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table481, "When ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table482 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table482.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table482.AddRow(new string[] {
                            "name",
                            "newuser2"});
#line 36
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table482, "When ");
#line hidden
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("extract parameter \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table483 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table483.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 44
 testRunner.When("execute HTTP GET request \'https://localhost:8080/users/$id$\'", ((string)(null)), table483, "When ");
#line hidden
#line 48
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.And("JSON \'$.name\'=\'newuser2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="remove a user")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "remove a user")]
        public void RemoveAUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("remove a user", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table484 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table484.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table484.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table484.AddRow(new string[] {
                            "scope",
                            "users"});
                table484.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 52
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table484, "When ");
#line hidden
#line 59
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table485 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table485.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table485.AddRow(new string[] {
                            "name",
                            "newuser3"});
#line 62
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table485, "When ");
#line hidden
#line 67
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("extract parameter \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table486 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table486.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 70
 testRunner.When("execute HTTP DELETE request \'https://localhost:8080/users/$id$\'", ((string)(null)), table486, "When ");
#line hidden
#line 74
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="update credential")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "update credential")]
        public void UpdateCredential()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("update credential", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table487 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table487.AddRow(new string[] {
                            "client_id",
                            "fiftySevenClient"});
                table487.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table487.AddRow(new string[] {
                            "scope",
                            "users"});
                table487.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 77
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table487, "When ");
#line hidden
#line 84
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table488 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table488.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table488.AddRow(new string[] {
                            "name",
                            "newuser4"});
#line 87
 testRunner.When("execute HTTP POST JSON request \'https://localhost:8080/users\'", ((string)(null)), table488, "When ");
#line hidden
#line 92
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("extract parameter \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table489 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table489.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table489.AddRow(new string[] {
                            "type",
                            "pwd"});
                table489.AddRow(new string[] {
                            "value",
                            "value"});
#line 95
 testRunner.When("execute HTTP PUT JSON request \'https://localhost:8080/users/$id$/credentials\'", ((string)(null)), table489, "When ");
#line hidden
#line 101
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UsersFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsersFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
