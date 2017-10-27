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
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table3.AddRow(new string[] {
                        "Date",
                        "Date",
                        "Equal"});
            table3.AddRow(new string[] {
                        "Amount",
                        "Amount",
                        "Equal"});
            table3.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
            table3.AddRow(new string[] {
                        "Id",
                        "Id",
                        "Equal"});
            table3.AddRow(new string[] {
                        "Narrative",
                        "Narrative",
                        "Equal"});
            table3.AddRow(new string[] {
                        "Description",
                        "Description",
                        "Equal"});
#line 20
 testRunner.And("a RuleSet With PropertyRules", ((string)(null)), table3, "And ");
#line 28
 testRunner.When("I call Reconcile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the result should be 4 Matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Reconcile Non Matching Client and Tutuka Transactions")]
        [NUnit.Framework.CategoryAttribute("reconcileengine")]
        public virtual void ReconcileNonMatchingClientAndTutukaTransactions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reconcile Non Matching Client and Tutuka Transactions", new string[] {
                        "reconcileengine"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table4.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table4.AddRow(new string[] {
                        "84012233581869",
                        "Card Campaign",
                        "1/12/2014  6:26:00 AM",
                        "-20000",
                        "Molepolole Filli100558    Gaborone      BW",
                        "DEDUCT",
                        "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2",
                        "1"});
            table4.AddRow(new string[] {
                        "0584012395072004",
                        "Card Campaign",
                        "2014-01-12 14:58:27",
                        "-10000",
                        "MAHALAPYE BRANCH          BOTSWANA      BW",
                        "DEDUCT",
                        "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2",
                        "1"});
            table4.AddRow(new string[] {
                        "0164012401925347",
                        "Card Campaign",
                        "2014-01-12 15:09:52",
                        "3880",
                        "370592 ENGEN LOBATSE      BOTSWANA      BW",
                        "REVERSAL",
                        "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1",
                        "1"});
#line 33
 testRunner.Given("A list of Client transactions", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table5.AddRow(new string[] {
                        "5840118086495112",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-10000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table5.AddRow(new string[] {
                        "840122335818692",
                        "Card Campaign",
                        "1/13/2014  6:26:00 AM",
                        "-20000",
                        "Molepolole Filli100558    Gaborone      BW",
                        "DEDUCT",
                        "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2",
                        "1"});
            table5.AddRow(new string[] {
                        "05840123950720042",
                        "Card Campaign",
                        "2014-01-12 14:58:27",
                        "-40000",
                        "MAHALAPYE BRANCH          BOTSWANA      BW",
                        "DEDUCT",
                        "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2",
                        "1"});
            table5.AddRow(new string[] {
                        "01640124019253472",
                        "Card Campaign",
                        "2014-02-12 15:09:52",
                        "6880",
                        "370592 ENGEN LOBATSE      BOTSWANA      BW",
                        "REVERSAL",
                        "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1",
                        "1"});
#line 39
 testRunner.And("a list of Non matching Tutuka Transactions With Different Ids", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table6.AddRow(new string[] {
                        "Date",
                        "Date",
                        "Equal"});
            table6.AddRow(new string[] {
                        "Amount",
                        "Amount",
                        "Equal"});
            table6.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
#line 45
 testRunner.And("a RuleSet With PropertyRules", ((string)(null)), table6, "And ");
#line 50
 testRunner.When("I call Reconcile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("the reconciled result should be 0 Matched Client Transactions 4 Unmatched Client " +
                    "transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.And("0 Matched Tutuka Transactions 4 Unmatched Tutuka transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Reconcile mix of matching and non matching Client and Tutuka Transactions")]
        [NUnit.Framework.CategoryAttribute("reconcileengine")]
        public virtual void ReconcileMixOfMatchingAndNonMatchingClientAndTutukaTransactions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reconcile mix of matching and non matching Client and Tutuka Transactions", new string[] {
                        "reconcileengine"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table7.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table7.AddRow(new string[] {
                        "84012233581869",
                        "Card Campaign",
                        "1/12/2014  6:26:00 AM",
                        "-20000",
                        "Molepolole Filli100558    Gaborone      BW",
                        "DEDUCT",
                        "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2",
                        "1"});
            table7.AddRow(new string[] {
                        "0584012395072004",
                        "Card Campaign",
                        "2014-01-12 14:58:27",
                        "-10000",
                        "MAHALAPYE BRANCH          BOTSWANA      BW",
                        "DEDUCT",
                        "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2",
                        "1"});
            table7.AddRow(new string[] {
                        "0164012401925347",
                        "Card Campaign",
                        "2014-01-12 15:09:52",
                        "3880",
                        "370592 ENGEN LOBATSE      BOTSWANA      BW",
                        "REVERSAL",
                        "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1",
                        "1"});
#line 56
 testRunner.Given("A list of Client transactions", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table8.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table8.AddRow(new string[] {
                        "84012233581869",
                        "Card Campaign",
                        "1/12/2014  6:26:00 AM",
                        "-20005",
                        "Molepolole Filli100558    Gaborone      BW",
                        "DEDUCT",
                        "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2",
                        "1"});
            table8.AddRow(new string[] {
                        "0584012395072004",
                        "Card Campaign",
                        "2014-01-12 14:58:27",
                        "-10000",
                        "MAHALAPYE BRANCH          BOTSWANA      BW",
                        "DEDUCT",
                        "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2",
                        "1"});
            table8.AddRow(new string[] {
                        "01640124019253472",
                        "Card Campaign",
                        "2014-01-12 15:09:52",
                        "38804",
                        "370592 ENGEN LOBATSE      BOTSWANA      BW",
                        "REVERSAL",
                        "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA133",
                        "1"});
#line 62
 testRunner.And("a list of Tutuka Transactions", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table9.AddRow(new string[] {
                        "Date",
                        "Date",
                        "Equal"});
            table9.AddRow(new string[] {
                        "Amount",
                        "Amount",
                        "Equal"});
            table9.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
            table9.AddRow(new string[] {
                        "Id",
                        "Id",
                        "Equal"});
            table9.AddRow(new string[] {
                        "Narrative",
                        "Narrative",
                        "Equal"});
            table9.AddRow(new string[] {
                        "Description",
                        "Description",
                        "Equal"});
#line 68
 testRunner.And("a RuleSet With PropertyRules", ((string)(null)), table9, "And ");
#line 76
 testRunner.When("I call Reconcile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("the result should be 2 Matched ReconciledItems and 3 Non Matched ReconciledItems", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Reconcile Client and Tutuka Transactions With Duplicate TransactionIds")]
        [NUnit.Framework.CategoryAttribute("reconcileengine")]
        public virtual void ReconcileClientAndTutukaTransactionsWithDuplicateTransactionIds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reconcile Client and Tutuka Transactions With Duplicate TransactionIds", new string[] {
                        "reconcileengine"});
#line 80
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table10.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table10.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 81
 testRunner.Given("A list of Client transactions", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table11.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table11.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 85
 testRunner.And("a list of matching Tutuka Transactions", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table12.AddRow(new string[] {
                        "Date",
                        "Date",
                        "Equal"});
            table12.AddRow(new string[] {
                        "Amount",
                        "Amount",
                        "Equal"});
            table12.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
            table12.AddRow(new string[] {
                        "Id",
                        "Id",
                        "Equal"});
            table12.AddRow(new string[] {
                        "Narrative",
                        "Narrative",
                        "Equal"});
            table12.AddRow(new string[] {
                        "Description",
                        "Description",
                        "Equal"});
#line 89
 testRunner.And("a RuleSet With PropertyRules", ((string)(null)), table12, "And ");
#line 97
 testRunner.When("I call Reconcile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("the result should 2 Matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
