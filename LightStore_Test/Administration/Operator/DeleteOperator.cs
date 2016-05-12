using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LightStore_Test
{
    [TestClass()]
    public class DeleteOperator : SqlDatabaseTestClass
    {

        public DeleteOperator()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Delete_Operator_By_ID_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteOperator));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition DeleteReturnCode;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition GetResultSet;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition GetReturnCode;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Delete_Operator_By_ID_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Unknown_Operator_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            this.Delete_Operator_By_IDData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Unknown_OperatorData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Delete_Operator_By_ID_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            DeleteReturnCode = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            GetResultSet = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            GetReturnCode = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Delete_Operator_By_ID_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_Unknown_Operator_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // Delete_Operator_By_ID_TestAction
            // 
            Delete_Operator_By_ID_TestAction.Conditions.Add(expectedSchemaCondition1);
            Delete_Operator_By_ID_TestAction.Conditions.Add(DeleteReturnCode);
            Delete_Operator_By_ID_TestAction.Conditions.Add(GetResultSet);
            Delete_Operator_By_ID_TestAction.Conditions.Add(GetReturnCode);
            resources.ApplyResources(Delete_Operator_By_ID_TestAction, "Delete_Operator_By_ID_TestAction");
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // DeleteReturnCode
            // 
            DeleteReturnCode.ColumnNumber = 1;
            DeleteReturnCode.Enabled = true;
            DeleteReturnCode.ExpectedValue = "1";
            DeleteReturnCode.Name = "DeleteReturnCode";
            DeleteReturnCode.NullExpected = false;
            DeleteReturnCode.ResultSet = 1;
            DeleteReturnCode.RowNumber = 1;
            // 
            // GetResultSet
            // 
            GetResultSet.Enabled = true;
            GetResultSet.Name = "GetResultSet";
            GetResultSet.ResultSet = 2;
            // 
            // GetReturnCode
            // 
            GetReturnCode.ColumnNumber = 1;
            GetReturnCode.Enabled = true;
            GetReturnCode.ExpectedValue = "0";
            GetReturnCode.Name = "GetReturnCode";
            GetReturnCode.NullExpected = false;
            GetReturnCode.ResultSet = 3;
            GetReturnCode.RowNumber = 1;
            // 
            // Delete_Operator_By_ID_PretestAction
            // 
            resources.ApplyResources(Delete_Operator_By_ID_PretestAction, "Delete_Operator_By_ID_PretestAction");
            // 
            // Error_Unknown_Operator_TestAction
            // 
            Error_Unknown_Operator_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Error_Unknown_Operator_TestAction, "Error_Unknown_Operator_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // Delete_Operator_By_IDData
            // 
            this.Delete_Operator_By_IDData.PosttestAction = null;
            this.Delete_Operator_By_IDData.PretestAction = Delete_Operator_By_ID_PretestAction;
            this.Delete_Operator_By_IDData.TestAction = Delete_Operator_By_ID_TestAction;
            // 
            // Error_Unknown_OperatorData
            // 
            this.Error_Unknown_OperatorData.PosttestAction = null;
            this.Error_Unknown_OperatorData.PretestAction = null;
            this.Error_Unknown_OperatorData.TestAction = Error_Unknown_Operator_TestAction;
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
        public void Delete_Operator_By_ID()
        {
            SqlDatabaseTestActions testActions = this.Delete_Operator_By_IDData;
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
        [ExpectedSqlException(Severity = 16, State = 255)]
        public void Error_Unknown_Operator()
        {
            SqlDatabaseTestActions testActions = this.Error_Unknown_OperatorData;
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
            catch (SqlException e)
            {
                Assert.IsTrue(Regex.IsMatch(e.Message, @"^Operator ""-?[0-9]+"" does no longer exist$"), e.Message);
                throw e;
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        private SqlDatabaseTestActions Delete_Operator_By_IDData;
        private SqlDatabaseTestActions Error_Unknown_OperatorData;
    }
}
