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
    public class uspCreateProduct : SqlDatabaseTestClass
    {

        public uspCreateProduct()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Product_uspCreateProductTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspCreateProduct));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Code;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Label;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Product_uspCreateProductTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_On_Null_Code_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Trhow_Error_On_Null_Label_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_If_Code_Already_Exists_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_If_Code_Already_Exists_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_If_GTIN_Already_Exists_In_Product_PretestAction;
            this.Product_uspCreateProductTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_On_Null_CodeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Trhow_Error_On_Null_LabelData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_If_Code_Already_ExistsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_If_GTIN_Already_Exists_In_ProductData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Product_uspCreateProductTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Code = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Label = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Product_uspCreateProductTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_On_Null_Code_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Trhow_Error_On_Null_Label_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_If_Code_Already_Exists_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_If_Code_Already_Exists_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_If_GTIN_Already_Exists_In_Product_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // Product_uspCreateProductTest_TestAction
            // 
            Product_uspCreateProductTest_TestAction.Conditions.Add(rowCountCondition1);
            Product_uspCreateProductTest_TestAction.Conditions.Add(Code);
            Product_uspCreateProductTest_TestAction.Conditions.Add(Label);
            Product_uspCreateProductTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(Product_uspCreateProductTest_TestAction, "Product_uspCreateProductTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // Code
            // 
            Code.ColumnNumber = 2;
            Code.Enabled = true;
            Code.ExpectedValue = "Unit Test";
            Code.Name = "Code";
            Code.NullExpected = false;
            Code.ResultSet = 1;
            Code.RowNumber = 1;
            // 
            // Label
            // 
            Label.ColumnNumber = 3;
            Label.Enabled = true;
            Label.ExpectedValue = "Fake product for unit test";
            Label.Name = "Label";
            Label.NullExpected = false;
            Label.ResultSet = 1;
            Label.RowNumber = 1;
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
            // Product_uspCreateProductTest_PretestAction
            // 
            resources.ApplyResources(Product_uspCreateProductTest_PretestAction, "Product_uspCreateProductTest_PretestAction");
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // Throw_Error_On_Null_Code_TestAction
            // 
            Throw_Error_On_Null_Code_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Throw_Error_On_Null_Code_TestAction, "Throw_Error_On_Null_Code_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // Trhow_Error_On_Null_Label_TestAction
            // 
            Trhow_Error_On_Null_Label_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(Trhow_Error_On_Null_Label_TestAction, "Trhow_Error_On_Null_Label_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // Throw_Error_If_Code_Already_Exists_TestAction
            // 
            Throw_Error_If_Code_Already_Exists_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(Throw_Error_If_Code_Already_Exists_TestAction, "Throw_Error_If_Code_Already_Exists_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // Throw_Error_If_Code_Already_Exists_PretestAction
            // 
            resources.ApplyResources(Throw_Error_If_Code_Already_Exists_PretestAction, "Throw_Error_If_Code_Already_Exists_PretestAction");
            // 
            // Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction
            // 
            Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction, "Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // Throw_Error_If_GTIN_Already_Exists_In_Product_PretestAction
            // 
            resources.ApplyResources(Throw_Error_If_GTIN_Already_Exists_In_Product_PretestAction, "Throw_Error_If_GTIN_Already_Exists_In_Product_PretestAction");
            // 
            // Product_uspCreateProductTestData
            // 
            this.Product_uspCreateProductTestData.PosttestAction = null;
            this.Product_uspCreateProductTestData.PretestAction = Product_uspCreateProductTest_PretestAction;
            this.Product_uspCreateProductTestData.TestAction = Product_uspCreateProductTest_TestAction;
            // 
            // Throw_Error_On_Null_CodeData
            // 
            this.Throw_Error_On_Null_CodeData.PosttestAction = null;
            this.Throw_Error_On_Null_CodeData.PretestAction = null;
            this.Throw_Error_On_Null_CodeData.TestAction = Throw_Error_On_Null_Code_TestAction;
            // 
            // Trhow_Error_On_Null_LabelData
            // 
            this.Trhow_Error_On_Null_LabelData.PosttestAction = null;
            this.Trhow_Error_On_Null_LabelData.PretestAction = null;
            this.Trhow_Error_On_Null_LabelData.TestAction = Trhow_Error_On_Null_Label_TestAction;
            // 
            // Throw_Error_If_Code_Already_ExistsData
            // 
            this.Throw_Error_If_Code_Already_ExistsData.PosttestAction = null;
            this.Throw_Error_If_Code_Already_ExistsData.PretestAction = Throw_Error_If_Code_Already_Exists_PretestAction;
            this.Throw_Error_If_Code_Already_ExistsData.TestAction = Throw_Error_If_Code_Already_Exists_TestAction;
            // 
            // Throw_Error_If_GTIN_Already_Exists_In_ProductData
            // 
            this.Throw_Error_If_GTIN_Already_Exists_In_ProductData.PosttestAction = null;
            this.Throw_Error_If_GTIN_Already_Exists_In_ProductData.PretestAction = Throw_Error_If_GTIN_Already_Exists_In_Product_PretestAction;
            this.Throw_Error_If_GTIN_Already_Exists_In_ProductData.TestAction = Throw_Error_If_GTIN_Already_Exists_In_Product_TestAction;
            // 
            // uspCreateProduct
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
        public void Product_uspCreateProductTest()
        {
            SqlDatabaseTestActions testActions = this.Product_uspCreateProductTestData;
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
        public void Throw_Error_On_Null_Code()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_On_Null_CodeData;
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
        public void Trhow_Error_On_Null_Label()
        {
            SqlDatabaseTestActions testActions = this.Trhow_Error_On_Null_LabelData;
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
        public void Throw_Error_If_Code_Already_Exists()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_If_Code_Already_ExistsData;
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
        [ExpectedSqlException(Severity = 16, State = 13)]
        public void Throw_Error_If_GTIN_Already_Exists_In_Product()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_If_GTIN_Already_Exists_In_ProductData;
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

        private SqlDatabaseTestActions Product_uspCreateProductTestData;
        private SqlDatabaseTestActions Throw_Error_On_Null_CodeData;
        private SqlDatabaseTestActions Trhow_Error_On_Null_LabelData;
        private SqlDatabaseTestActions Throw_Error_If_Code_Already_ExistsData;
        private SqlDatabaseTestActions Throw_Error_If_GTIN_Already_Exists_In_ProductData;
    }
}
