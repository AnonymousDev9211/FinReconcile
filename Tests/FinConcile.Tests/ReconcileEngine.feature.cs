﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FinConcile.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ReconcileEngine")]
    public partial class ReconcileEngineFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ReconcileEngine.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ReconcileEngine", "\tIn order to reconcile transactions\r\n\tAs a user\r\n\tI want to be told whether a lis" +
                    "t of client and tutuka tranascations are matched or notmatched", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Reconcile Matching Client and Tutuka Transactions")]
        [NUnit.Framework.CategoryAttribute("reconcileengine")]
        public virtual void ReconcileMatchingClientAndTutukaTransactions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reconcile Matching Client and Tutuka Transactions", new string[] {
                        "reconcileengine"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table1.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table1.AddRow(new string[] {
                        "84012233581869",
                        "Card Campaign",
                        "1/12/2014  6:26:00 AM",
                        "-20000",
                        "Molepolole Filli100558    Gaborone      BW",
                        "DEDUCT",
                        "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2",
                        "1"});
            table1.AddRow(new string[] {
                        "0584012395072004",
                        "Card Campaign",
                        "2014-01-12 14:58:27",
                        "-10000",
                        "MAHALAPYE BRANCH          BOTSWANA      BW",
                        "DEDUCT",
                        "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2",
                        "1"});
            table1.AddRow(new string[] {
                        "0164012401925347",
                        "Card Campaign",
                        "2014-01-12 15:09:52",
                        "3880",
                        "370592 ENGEN LOBATSE      BOTSWANA      BW",
                        "REVERSAL",
                        "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1",
                        "1"});
#line 8
 testRunner.Given("A list of Client transactions", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table2.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table2.AddRow(new string[] {
                        "84012233581869",
                        "Card Campaign",
                        "1/12/2014  6:26:00 AM",
                        "-20000",
                        "Molepolole Filli100558    Gaborone      BW",
                        "DEDUCT",
                        "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2",
                        "1"});
            table2.AddRow(new string[] {
                        "0584012395072004",
                        "Card Campaign",
                        "2014-01-12 14:58:27",
                        "-10000",
                        "MAHALAPYE BRANCH          BOTSWANA      BW",
                        "DEDUCT",
                        "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2",
                        "1"});
            table2.AddRow(new string[] {
                        "0164012401925347",
                        "Card Campaign",
                        "2014-01-12 15:09:52",
                        "3880",
                        "370592 ENGEN LOBATSE      BOTSWANA      BW",
                        "REVERSAL",
                        "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1",
                        "1"});
#line 14
 testRunner.And("a list of matching Tutuka Transactions", ((string)(null)), table2, "And ");
#line 20
 testRunner.When("I call Reconcile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("the result should be 4 Matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
