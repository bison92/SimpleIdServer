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
    public partial class UMAPermissionsErrorsFeature : object, Xunit.IClassFixture<UMAPermissionsErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAPermissionsErrors.feature"
#line hidden
        
        public UMAPermissionsErrorsFeature(UMAPermissionsErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAPermissionsErrors", "\tCheck errors returned by the /perm\t", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="resource_id parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAPermissionsErrors")]
        [Xunit.TraitAttribute("Description", "resource_id parameter is required")]
        public void Resource_IdParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("resource_id parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table406 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table406.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table406.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table406.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table406.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table406, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table407 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table407.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP POST JSON request \'http://localhost/perm\'", ((string)(null)), table407, "And ");
#line hidden
#line 19
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Then("JSON \'error_description\'=\'missing parameter resource_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="resource_scopes parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAPermissionsErrors")]
        [Xunit.TraitAttribute("Description", "resource_scopes parameter is required")]
        public void Resource_ScopesParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("resource_scopes parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table408 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table408.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table408.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table408.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table408.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 26
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table408, "When ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table409 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table409.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table409.AddRow(new string[] {
                            "resource_id",
                            "id"});
#line 36
 testRunner.And("execute HTTP POST JSON request \'http://localhost/perm\'", ((string)(null)), table409, "And ");
#line hidden
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.Then("JSON \'error_description\'=\'missing parameter resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="resource_id must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAPermissionsErrors")]
        [Xunit.TraitAttribute("Description", "resource_id must exists")]
        public void Resource_IdMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("resource_id must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table410 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table410.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table410.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table410.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table410.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 48
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table410, "When ");
#line hidden
#line 55
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table411 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table411.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table411.AddRow(new string[] {
                            "resource_id",
                            "invalid"});
                table411.AddRow(new string[] {
                            "resource_scopes",
                            "[ \"scope\" ]"});
#line 58
 testRunner.And("execute HTTP POST JSON request \'http://localhost/perm\'", ((string)(null)), table411, "And ");
#line hidden
#line 64
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.Then("JSON \'error\'=\'invalid_resource_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Then("JSON \'error_description\'=\'At least one of the provided resource identifiers was n" +
                        "ot found at the authorization server.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="scope must be valid")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAPermissionsErrors")]
        [Xunit.TraitAttribute("Description", "scope must be valid")]
        public void ScopeMustBeValid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scope must be valid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 70
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table412 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table412.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table412.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table412.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table412.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 71
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table412, "When ");
#line hidden
#line 78
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table413 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table413.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table413.AddRow(new string[] {
                            "resource_id",
                            "id"});
                table413.AddRow(new string[] {
                            "resource_scopes",
                            "[ \"invalid\" ]"});
#line 81
 testRunner.And("execute HTTP POST JSON request \'http://localhost/perm\'", ((string)(null)), table413, "And ");
#line hidden
#line 87
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.Then("JSON \'error\'=\'invalid_scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.Then("JSON \'error_description\'=\'At least one of the scopes included in the request does" +
                        " not match an available scope for any of the resources associated with requested" +
                        " permissions for the permission ticket provided by the client.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UMAPermissionsErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAPermissionsErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
