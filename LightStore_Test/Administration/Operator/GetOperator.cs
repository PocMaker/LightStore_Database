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
    public class GetOperator : SqlDatabaseTestClass
    {

        public GetOperator()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Get_By_Login_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetOperator));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Get_By_Login_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Get_By_Id_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Get_By_Id_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Get_All_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Get_All_PretestAction;
            this.Get_By_LoginData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Get_By_IdData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Get_AllData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Get_By_Login_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Get_By_Login_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Get_By_Id_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Get_By_Id_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Get_All_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Get_All_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // Get_By_Login_TestAction
            // 
            Get_By_Login_TestAction.Conditions.Add(rowCountCondition1);
            Get_By_Login_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(Get_By_Login_TestAction, "Get_By_Login_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 4;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "Test";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // Get_By_Login_PretestAction
            // 
            resources.ApplyResources(Get_By_Login_PretestAction, "Get_By_Login_PretestAction");
            // 
            // Get_By_Id_TestAction
            // 
            Get_By_Id_TestAction.Conditions.Add(rowCountCondition2);
            Get_By_Id_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(Get_By_Id_TestAction, "Get_By_Id_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 4;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "Test";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // Get_By_Id_PretestAction
            // 
            resources.ApplyResources(Get_By_Id_PretestAction, "Get_By_Id_PretestAction");
            // 
            // Get_All_TestAction
            // 
            Get_All_TestAction.Conditions.Add(expectedSchemaCondition2);
            Get_All_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            Get_All_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(Get_All_TestAction, "Get_All_TestAction");
            // 
            // expectedSchemaCondition2
            // 
            expectedSchemaCondition2.Enabled = true;
            expectedSchemaCondition2.Name = "expectedSchemaCondition2";
            resources.ApplyResources(expectedSchemaCondition2, "expectedSchemaCondition2");
            expectedSchemaCondition2.Verbose = false;
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 4;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "SuperAdmin";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // Get_All_PretestAction
            // 
            resources.ApplyResources(Get_All_PretestAction, "Get_All_PretestAction");
            // 
            // Get_By_LoginData
            // 
            this.Get_By_LoginData.PosttestAction = null;
            this.Get_By_LoginData.PretestAction = Get_By_Login_PretestAction;
            this.Get_By_LoginData.TestAction = Get_By_Login_TestAction;
            // 
            // Get_By_IdData
            // 
            this.Get_By_IdData.PosttestAction = null;
            this.Get_By_IdData.PretestAction = Get_By_Id_PretestAction;
            this.Get_By_IdData.TestAction = Get_By_Id_TestAction;
            // 
            // Get_AllData
            // 
            this.Get_AllData.PosttestAction = null;
            this.Get_AllData.PretestAction = Get_All_PretestAction;
            this.Get_AllData.TestAction = Get_All_TestAction;
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
        [TestCategory("Administration.Operator")]
        public void Get_By_Login()
        {
            SqlDatabaseTestActions testActions = this.Get_By_LoginData;
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
        [TestCategory("Administration.Operator")]
        public void Get_By_Id()
        {
            SqlDatabaseTestActions testActions = this.Get_By_IdData;
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
        [TestCategory("Administration.Operator")]
        public void Get_All()
        {
            SqlDatabaseTestActions testActions = this.Get_AllData;
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


        private SqlDatabaseTestActions Get_By_LoginData;
        private SqlDatabaseTestActions Get_By_IdData;
        private SqlDatabaseTestActions Get_AllData;
    }
}
