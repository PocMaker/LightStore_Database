using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LightStore_Test
{
    [TestClass()]
    public class uspCreatePackaging : SqlDatabaseTestClass
    {

        public uspCreatePackaging()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspCreatePackagingTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspCreatePackaging));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspCreatePackagingTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Quantity_Is_Negative_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Gtin_Already_Exists_In_Packaging_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_ProductId_Does_Not_Exist_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_FromId_Does_Not_Exist_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Gtin_Already_Exists_In_Product_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Gtin_Already_Exists_In_Product_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            this.uspCreatePackagingTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_Quantity_Is_NegativeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_Gtin_Already_Exists_In_PackagingData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_ProductId_Does_Not_ExistData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_FromId_Does_Not_ExistData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_Gtin_Already_Exists_In_ProductData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_Unity_Is_Not_Well_FormedData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            uspCreatePackagingTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            uspCreatePackagingTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_When_Quantity_Is_Negative_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_When_Gtin_Already_Exists_In_Packaging_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_When_ProductId_Does_Not_Exist_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_When_FromId_Does_Not_Exist_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_When_Gtin_Already_Exists_In_Product_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_When_Gtin_Already_Exists_In_Product_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // uspCreatePackagingTest_TestAction
            // 
            uspCreatePackagingTest_TestAction.Conditions.Add(expectedSchemaCondition1);
            uspCreatePackagingTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(uspCreatePackagingTest_TestAction, "uspCreatePackagingTest_TestAction");
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "1";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 2;
            scalarValueCondition1.RowNumber = 1;
            // 
            // uspCreatePackagingTest_PretestAction
            // 
            resources.ApplyResources(uspCreatePackagingTest_PretestAction, "uspCreatePackagingTest_PretestAction");
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // Throw_Error_When_Quantity_Is_Negative_TestAction
            // 
            Throw_Error_When_Quantity_Is_Negative_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(Throw_Error_When_Quantity_Is_Negative_TestAction, "Throw_Error_When_Quantity_Is_Negative_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction
            // 
            Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction, "Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_Packaging_PretestAction
            // 
            resources.ApplyResources(Throw_Error_When_Gtin_Already_Exists_In_Packaging_PretestAction, "Throw_Error_When_Gtin_Already_Exists_In_Packaging_PretestAction");
            // 
            // Throw_Error_When_ProductId_Does_Not_Exist_TestAction
            // 
            Throw_Error_When_ProductId_Does_Not_Exist_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(Throw_Error_When_ProductId_Does_Not_Exist_TestAction, "Throw_Error_When_ProductId_Does_Not_Exist_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // Throw_Error_When_FromId_Does_Not_Exist_TestAction
            // 
            Throw_Error_When_FromId_Does_Not_Exist_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(Throw_Error_When_FromId_Does_Not_Exist_TestAction, "Throw_Error_When_FromId_Does_Not_Exist_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction
            // 
            Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction.Conditions.Add(inconclusiveCondition6);
            resources.ApplyResources(Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction, "Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction");
            // 
            // inconclusiveCondition6
            // 
            inconclusiveCondition6.Enabled = true;
            inconclusiveCondition6.Name = "inconclusiveCondition6";
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_Product_PretestAction
            // 
            resources.ApplyResources(Throw_Error_When_Gtin_Already_Exists_In_Product_PretestAction, "Throw_Error_When_Gtin_Already_Exists_In_Product_PretestAction");
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_Product_PosttestAction
            // 
            resources.ApplyResources(Throw_Error_When_Gtin_Already_Exists_In_Product_PosttestAction, "Throw_Error_When_Gtin_Already_Exists_In_Product_PosttestAction");
            // 
            // uspCreatePackagingTestData
            // 
            this.uspCreatePackagingTestData.PosttestAction = null;
            this.uspCreatePackagingTestData.PretestAction = uspCreatePackagingTest_PretestAction;
            this.uspCreatePackagingTestData.TestAction = uspCreatePackagingTest_TestAction;
            // 
            // Throw_Error_When_Quantity_Is_NegativeData
            // 
            this.Throw_Error_When_Quantity_Is_NegativeData.PosttestAction = null;
            this.Throw_Error_When_Quantity_Is_NegativeData.PretestAction = null;
            this.Throw_Error_When_Quantity_Is_NegativeData.TestAction = Throw_Error_When_Quantity_Is_Negative_TestAction;
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_PackagingData
            // 
            this.Throw_Error_When_Gtin_Already_Exists_In_PackagingData.PosttestAction = null;
            this.Throw_Error_When_Gtin_Already_Exists_In_PackagingData.PretestAction = Throw_Error_When_Gtin_Already_Exists_In_Packaging_PretestAction;
            this.Throw_Error_When_Gtin_Already_Exists_In_PackagingData.TestAction = Throw_Error_When_Gtin_Already_Exists_In_Packaging_TestAction;
            // 
            // Throw_Error_When_ProductId_Does_Not_ExistData
            // 
            this.Throw_Error_When_ProductId_Does_Not_ExistData.PosttestAction = null;
            this.Throw_Error_When_ProductId_Does_Not_ExistData.PretestAction = null;
            this.Throw_Error_When_ProductId_Does_Not_ExistData.TestAction = Throw_Error_When_ProductId_Does_Not_Exist_TestAction;
            // 
            // Throw_Error_When_FromId_Does_Not_ExistData
            // 
            this.Throw_Error_When_FromId_Does_Not_ExistData.PosttestAction = null;
            this.Throw_Error_When_FromId_Does_Not_ExistData.PretestAction = null;
            this.Throw_Error_When_FromId_Does_Not_ExistData.TestAction = Throw_Error_When_FromId_Does_Not_Exist_TestAction;
            // 
            // Throw_Error_When_Gtin_Already_Exists_In_ProductData
            // 
            this.Throw_Error_When_Gtin_Already_Exists_In_ProductData.PosttestAction = Throw_Error_When_Gtin_Already_Exists_In_Product_PosttestAction;
            this.Throw_Error_When_Gtin_Already_Exists_In_ProductData.PretestAction = Throw_Error_When_Gtin_Already_Exists_In_Product_PretestAction;
            this.Throw_Error_When_Gtin_Already_Exists_In_ProductData.TestAction = Throw_Error_When_Gtin_Already_Exists_In_Product_TestAction;
            // 
            // Throw_Error_When_Unity_Is_Not_Well_FormedData
            // 
            this.Throw_Error_When_Unity_Is_Not_Well_FormedData.PosttestAction = null;
            this.Throw_Error_When_Unity_Is_Not_Well_FormedData.PretestAction = null;
            this.Throw_Error_When_Unity_Is_Not_Well_FormedData.TestAction = Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction;
            // 
            // Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction
            // 
            Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction, "Throw_Error_When_Unity_Is_Not_Well_Formed_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // uspCreatePackaging
            // 
            this.TestInitializeAction = testInitializeAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void uspCreatePackagingTest()
        {
            SqlDatabaseTestActions testActions = this.uspCreatePackagingTestData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [ExpectedSqlException(Severity = 16, State = 12)]
        public void Throw_Error_When_Quantity_Is_Negative()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_Quantity_Is_NegativeData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [ExpectedSqlException(Severity = 16, State = 11)]
        public void Throw_Error_When_Gtin_Already_Exists_In_Packaging()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_Gtin_Already_Exists_In_PackagingData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [ExpectedSqlException(Severity = 16, State = 0)]
        public void Throw_Error_When_ProductId_Does_Not_Exist()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_ProductId_Does_Not_ExistData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [ExpectedSqlException(Severity = 16, State = 0)]
        public void Throw_Error_When_FromId_Does_Not_Exist()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_FromId_Does_Not_ExistData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [ExpectedSqlException(Severity = 16, State = 10)]
        public void Throw_Error_When_Gtin_Already_Exists_In_Product()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_Gtin_Already_Exists_In_ProductData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [ExpectedSqlException(Severity = 16, State = 0)]
        public void Throw_Error_When_Unity_Is_Not_Well_Formed()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_Unity_Is_Not_Well_FormedData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }



        private SqlDatabaseTestActions uspCreatePackagingTestData;
        private SqlDatabaseTestActions Throw_Error_When_Quantity_Is_NegativeData;
        private SqlDatabaseTestActions Throw_Error_When_Gtin_Already_Exists_In_PackagingData;
        private SqlDatabaseTestActions Throw_Error_When_ProductId_Does_Not_ExistData;
        private SqlDatabaseTestActions Throw_Error_When_FromId_Does_Not_ExistData;
        private SqlDatabaseTestActions Throw_Error_When_Gtin_Already_Exists_In_ProductData;
        private SqlDatabaseTestActions Throw_Error_When_Unity_Is_Not_Well_FormedData;
    }
}
