using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace LightStore_Test
{
    [TestClass()]
    public class CreateOperator : SqlDatabaseTestClass
    {

        public CreateOperator()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Create_Operator_Login_Test_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOperator));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Create_Operator_Login_Test_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_FirstName_NULL_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_FirstName_NULL_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_LastName_NULL_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_LastName_NULL_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Login_NULL_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Login_NULL_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_FirstName_Empty_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_LastName_Empty_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Login_Empty_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Login_Already_Exists_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_FirstName_Empty_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_LastName_Empty_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Login_Empty_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Login_Already_Exists_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            this.Create_Operator_Login_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_FirstName_NULLData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_LastName_NULLData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Login_NULLData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_FirstName_EmptyData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_LastName_EmptyData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Login_EmptyData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Login_Already_ExistsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Create_Operator_Login_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Create_Operator_Login_Test_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            Error_FirstName_NULL_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_FirstName_NULL_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_LastName_NULL_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_LastName_NULL_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_Login_NULL_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_Login_NULL_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_FirstName_Empty_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_LastName_Empty_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_Login_Empty_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_Login_Already_Exists_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_FirstName_Empty_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_LastName_Empty_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_Login_Empty_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_Login_Already_Exists_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // Create_Operator_Login_Test_TestAction
            // 
            Create_Operator_Login_Test_TestAction.Conditions.Add(expectedSchemaCondition1);
            Create_Operator_Login_Test_TestAction.Conditions.Add(rowCountCondition1);
            Create_Operator_Login_Test_TestAction.Conditions.Add(scalarValueCondition1);
            Create_Operator_Login_Test_TestAction.Conditions.Add(scalarValueCondition2);
            Create_Operator_Login_Test_TestAction.Conditions.Add(scalarValueCondition3);
            Create_Operator_Login_Test_TestAction.Conditions.Add(scalarValueCondition4);
            Create_Operator_Login_Test_TestAction.Conditions.Add(scalarValueCondition5);
            Create_Operator_Login_Test_TestAction.Conditions.Add(scalarValueCondition6);
            resources.ApplyResources(Create_Operator_Login_Test_TestAction, "Create_Operator_Login_Test_TestAction");
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
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
            scalarValueCondition1.ColumnNumber = 2;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "FirstName";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 3;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "LastName";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 4;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "Test";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 5;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = null;
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = true;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 6;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "False";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // Create_Operator_Login_Test_PretestAction
            // 
            Create_Operator_Login_Test_PretestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(Create_Operator_Login_Test_PretestAction, "Create_Operator_Login_Test_PretestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "-1113720315";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // Error_FirstName_NULL_TestAction
            // 
            Error_FirstName_NULL_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Error_FirstName_NULL_TestAction, "Error_FirstName_NULL_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // Error_FirstName_NULL_PretestAction
            // 
            resources.ApplyResources(Error_FirstName_NULL_PretestAction, "Error_FirstName_NULL_PretestAction");
            // 
            // Error_LastName_NULL_TestAction
            // 
            Error_LastName_NULL_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(Error_LastName_NULL_TestAction, "Error_LastName_NULL_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // Error_LastName_NULL_PretestAction
            // 
            resources.ApplyResources(Error_LastName_NULL_PretestAction, "Error_LastName_NULL_PretestAction");
            // 
            // Error_Login_NULL_TestAction
            // 
            Error_Login_NULL_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(Error_Login_NULL_TestAction, "Error_Login_NULL_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // Error_Login_NULL_PretestAction
            // 
            resources.ApplyResources(Error_Login_NULL_PretestAction, "Error_Login_NULL_PretestAction");
            // 
            // Error_FirstName_Empty_TestAction
            // 
            Error_FirstName_Empty_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(Error_FirstName_Empty_TestAction, "Error_FirstName_Empty_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // Error_LastName_Empty_TestAction
            // 
            Error_LastName_Empty_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(Error_LastName_Empty_TestAction, "Error_LastName_Empty_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // Error_Login_Empty_TestAction
            // 
            Error_Login_Empty_TestAction.Conditions.Add(inconclusiveCondition6);
            resources.ApplyResources(Error_Login_Empty_TestAction, "Error_Login_Empty_TestAction");
            // 
            // inconclusiveCondition6
            // 
            inconclusiveCondition6.Enabled = true;
            inconclusiveCondition6.Name = "inconclusiveCondition6";
            // 
            // Error_Login_Already_Exists_TestAction
            // 
            Error_Login_Already_Exists_TestAction.Conditions.Add(inconclusiveCondition7);
            resources.ApplyResources(Error_Login_Already_Exists_TestAction, "Error_Login_Already_Exists_TestAction");
            // 
            // inconclusiveCondition7
            // 
            inconclusiveCondition7.Enabled = true;
            inconclusiveCondition7.Name = "inconclusiveCondition7";
            // 
            // Error_FirstName_Empty_PretestAction
            // 
            resources.ApplyResources(Error_FirstName_Empty_PretestAction, "Error_FirstName_Empty_PretestAction");
            // 
            // Error_LastName_Empty_PretestAction
            // 
            resources.ApplyResources(Error_LastName_Empty_PretestAction, "Error_LastName_Empty_PretestAction");
            // 
            // Error_Login_Empty_PretestAction
            // 
            resources.ApplyResources(Error_Login_Empty_PretestAction, "Error_Login_Empty_PretestAction");
            // 
            // Error_Login_Already_Exists_PretestAction
            // 
            resources.ApplyResources(Error_Login_Already_Exists_PretestAction, "Error_Login_Already_Exists_PretestAction");
            // 
            // Create_Operator_Login_TestData
            // 
            this.Create_Operator_Login_TestData.PosttestAction = null;
            this.Create_Operator_Login_TestData.PretestAction = Create_Operator_Login_Test_PretestAction;
            this.Create_Operator_Login_TestData.TestAction = Create_Operator_Login_Test_TestAction;
            // 
            // Error_FirstName_NULLData
            // 
            this.Error_FirstName_NULLData.PosttestAction = null;
            this.Error_FirstName_NULLData.PretestAction = Error_FirstName_NULL_PretestAction;
            this.Error_FirstName_NULLData.TestAction = Error_FirstName_NULL_TestAction;
            // 
            // Error_LastName_NULLData
            // 
            this.Error_LastName_NULLData.PosttestAction = null;
            this.Error_LastName_NULLData.PretestAction = Error_LastName_NULL_PretestAction;
            this.Error_LastName_NULLData.TestAction = Error_LastName_NULL_TestAction;
            // 
            // Error_Login_NULLData
            // 
            this.Error_Login_NULLData.PosttestAction = null;
            this.Error_Login_NULLData.PretestAction = Error_Login_NULL_PretestAction;
            this.Error_Login_NULLData.TestAction = Error_Login_NULL_TestAction;
            // 
            // Error_FirstName_EmptyData
            // 
            this.Error_FirstName_EmptyData.PosttestAction = null;
            this.Error_FirstName_EmptyData.PretestAction = Error_FirstName_Empty_PretestAction;
            this.Error_FirstName_EmptyData.TestAction = Error_FirstName_Empty_TestAction;
            // 
            // Error_LastName_EmptyData
            // 
            this.Error_LastName_EmptyData.PosttestAction = null;
            this.Error_LastName_EmptyData.PretestAction = Error_LastName_Empty_PretestAction;
            this.Error_LastName_EmptyData.TestAction = Error_LastName_Empty_TestAction;
            // 
            // Error_Login_EmptyData
            // 
            this.Error_Login_EmptyData.PosttestAction = null;
            this.Error_Login_EmptyData.PretestAction = Error_Login_Empty_PretestAction;
            this.Error_Login_EmptyData.TestAction = Error_Login_Empty_TestAction;
            // 
            // Error_Login_Already_ExistsData
            // 
            this.Error_Login_Already_ExistsData.PosttestAction = null;
            this.Error_Login_Already_ExistsData.PretestAction = Error_Login_Already_Exists_PretestAction;
            this.Error_Login_Already_ExistsData.TestAction = Error_Login_Already_Exists_TestAction;
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "1";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 2;
            scalarValueCondition6.RowNumber = 1;
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
        public void Create_Operator_Login_Test()
        {
            SqlDatabaseTestActions testActions = this.Create_Operator_Login_TestData;
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
        [ExpectedSqlException(Severity = 16, State = 10)]
        public void Error_FirstName_NULL()
        {
            SqlDatabaseTestActions testActions = this.Error_FirstName_NULLData;
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
                Assert.AreEqual("FirstName cannot be EMPTY", e.Message);
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
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        [ExpectedSqlException(Severity = 16, State = 11)]
        public void Error_LastName_NULL()
        {
            SqlDatabaseTestActions testActions = this.Error_LastName_NULLData;
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
                Assert.AreEqual("LastName cannot be EMPTY", e.Message);
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
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        [ExpectedSqlException(Severity = 16, State = 12)]
        public void Error_Login_NULL()
        {
            SqlDatabaseTestActions testActions = this.Error_Login_NULLData;
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
                Assert.AreEqual("Login cannot be EMPTY", e.Message);
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
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        [ExpectedSqlException(Severity = 16, State = 10)]
        public void Error_FirstName_Empty()
        {
            SqlDatabaseTestActions testActions = this.Error_FirstName_EmptyData;
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
        [ExpectedSqlException(Severity = 16, State = 11)]
        public void Error_LastName_Empty()
        {
            SqlDatabaseTestActions testActions = this.Error_LastName_EmptyData;
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
        [ExpectedSqlException(Severity = 16, State = 12)]
        public void Error_Login_Empty()
        {
            SqlDatabaseTestActions testActions = this.Error_Login_EmptyData;
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
        [ExpectedSqlException(Severity = 16, State = 13)]
        public void Error_Login_Already_Exists()
        {
            SqlDatabaseTestActions testActions = this.Error_Login_Already_ExistsData;
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
                Assert.AreEqual("Login already exists", e.Message);
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


        private SqlDatabaseTestActions Create_Operator_Login_TestData;
        private SqlDatabaseTestActions Error_FirstName_NULLData;
        private SqlDatabaseTestActions Error_LastName_NULLData;
        private SqlDatabaseTestActions Error_Login_NULLData;
        private SqlDatabaseTestActions Error_FirstName_EmptyData;
        private SqlDatabaseTestActions Error_LastName_EmptyData;
        private SqlDatabaseTestActions Error_Login_EmptyData;
        private SqlDatabaseTestActions Error_Login_Already_ExistsData;
    }
}
