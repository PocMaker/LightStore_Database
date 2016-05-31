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
    public class uspDeleteProduct : SqlDatabaseTestClass
    {

        public uspDeleteProduct()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspDeleteProductTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspDeleteProduct));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspDeleteProductTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            this.uspDeleteProductTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_Produc_Id_Does_Not_ExistData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            uspDeleteProductTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            uspDeleteProductTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // uspDeleteProductTest_TestAction
            // 
            uspDeleteProductTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(uspDeleteProductTest_TestAction, "uspDeleteProductTest_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "1";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // uspDeleteProductTest_PretestAction
            // 
            resources.ApplyResources(uspDeleteProductTest_PretestAction, "uspDeleteProductTest_PretestAction");
            // 
            // Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction
            // 
            Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction, "Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // uspDeleteProductTestData
            // 
            this.uspDeleteProductTestData.PosttestAction = null;
            this.uspDeleteProductTestData.PretestAction = uspDeleteProductTest_PretestAction;
            this.uspDeleteProductTestData.TestAction = uspDeleteProductTest_TestAction;
            // 
            // Throw_Error_When_Produc_Id_Does_Not_ExistData
            // 
            this.Throw_Error_When_Produc_Id_Does_Not_ExistData.PosttestAction = null;
            this.Throw_Error_When_Produc_Id_Does_Not_ExistData.PretestAction = null;
            this.Throw_Error_When_Produc_Id_Does_Not_ExistData.TestAction = Throw_Error_When_Produc_Id_Does_Not_Exist_TestAction;
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
        public void uspDeleteProductTest()
        {
            SqlDatabaseTestActions testActions = this.uspDeleteProductTestData;
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
        [ExpectedSqlException(Severity = 16, State = 255)]
        public void Throw_Error_When_Produc_Id_Does_Not_Exist()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_Produc_Id_Does_Not_ExistData;
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

        private SqlDatabaseTestActions uspDeleteProductTestData;
        private SqlDatabaseTestActions Throw_Error_When_Produc_Id_Does_Not_ExistData;
    }
}
