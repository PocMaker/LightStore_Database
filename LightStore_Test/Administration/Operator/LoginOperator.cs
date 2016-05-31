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
    public class LoginOperator : SqlDatabaseTestClass
    {

        public LoginOperator()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Login_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Login_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOperator));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Login;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition IsPasswordDefined;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition LoginReturnedCode;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Unknown_Login_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Unknown_Password_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Unknown_Password_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Unknown_Login_PretestAction;
            this.LoginData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Unknown_LoginData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Unknown_PasswordData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Login_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Login_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Login = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            IsPasswordDefined = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            LoginReturnedCode = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Error_Unknown_Login_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_Unknown_Password_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_Unknown_Password_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_Unknown_Login_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // Login_TestAction
            // 
            Login_TestAction.Conditions.Add(expectedSchemaCondition1);
            Login_TestAction.Conditions.Add(rowCountCondition1);
            Login_TestAction.Conditions.Add(Login);
            Login_TestAction.Conditions.Add(IsPasswordDefined);
            Login_TestAction.Conditions.Add(LoginReturnedCode);
            resources.ApplyResources(Login_TestAction, "Login_TestAction");
            // 
            // LoginData
            // 
            this.LoginData.PosttestAction = null;
            this.LoginData.PretestAction = Login_PretestAction;
            this.LoginData.TestAction = Login_TestAction;
            // 
            // Login_PretestAction
            // 
            resources.ApplyResources(Login_PretestAction, "Login_PretestAction");
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
            // Login
            // 
            Login.ColumnNumber = 4;
            Login.Enabled = true;
            Login.ExpectedValue = "Test";
            Login.Name = "Login";
            Login.NullExpected = false;
            Login.ResultSet = 1;
            Login.RowNumber = 1;
            // 
            // IsPasswordDefined
            // 
            IsPasswordDefined.ColumnNumber = 6;
            IsPasswordDefined.Enabled = true;
            IsPasswordDefined.ExpectedValue = "True";
            IsPasswordDefined.Name = "IsPasswordDefined";
            IsPasswordDefined.NullExpected = false;
            IsPasswordDefined.ResultSet = 1;
            IsPasswordDefined.RowNumber = 1;
            // 
            // LoginReturnedCode
            // 
            LoginReturnedCode.ColumnNumber = 1;
            LoginReturnedCode.Enabled = true;
            LoginReturnedCode.ExpectedValue = "1";
            LoginReturnedCode.Name = "LoginReturnedCode";
            LoginReturnedCode.NullExpected = false;
            LoginReturnedCode.ResultSet = 2;
            LoginReturnedCode.RowNumber = 1;
            // 
            // Error_Unknown_LoginData
            // 
            this.Error_Unknown_LoginData.PosttestAction = null;
            this.Error_Unknown_LoginData.PretestAction = Error_Unknown_Login_PretestAction;
            this.Error_Unknown_LoginData.TestAction = Error_Unknown_Login_TestAction;
            // 
            // Error_Unknown_Login_TestAction
            // 
            Error_Unknown_Login_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Error_Unknown_Login_TestAction, "Error_Unknown_Login_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // Error_Unknown_PasswordData
            // 
            this.Error_Unknown_PasswordData.PosttestAction = null;
            this.Error_Unknown_PasswordData.PretestAction = Error_Unknown_Password_PretestAction;
            this.Error_Unknown_PasswordData.TestAction = Error_Unknown_Password_TestAction;
            // 
            // Error_Unknown_Password_TestAction
            // 
            Error_Unknown_Password_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(Error_Unknown_Password_TestAction, "Error_Unknown_Password_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // Error_Unknown_Password_PretestAction
            // 
            resources.ApplyResources(Error_Unknown_Password_PretestAction, "Error_Unknown_Password_PretestAction");
            // 
            // Error_Unknown_Login_PretestAction
            // 
            resources.ApplyResources(Error_Unknown_Login_PretestAction, "Error_Unknown_Login_PretestAction");
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
        public void Login()
        {
            SqlDatabaseTestActions testActions = this.LoginData;
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
        public void Error_Unknown_Login()
        {
            SqlDatabaseTestActions testActions = this.Error_Unknown_LoginData;
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
                Assert.AreEqual("Login and password does not match", e.Message);
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
        public void Error_Unknown_Password()
        {
            SqlDatabaseTestActions testActions = this.Error_Unknown_PasswordData;
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
                Assert.AreEqual("Login and password does not match", e.Message);
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


        private SqlDatabaseTestActions LoginData;
        private SqlDatabaseTestActions Error_Unknown_LoginData;
        private SqlDatabaseTestActions Error_Unknown_PasswordData;
    }
}
