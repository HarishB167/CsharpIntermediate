using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class ExercisePolymorphism
    {
        public void run()
        {
            Console.WriteLine("Exercise Polymorphism.\n");

            
            var sqlConnection = new SQLConnection("connection string for sql server");
            var instruction = "INSTRUCTION TO SQL SERVER";
            var command = new DbCommand(sqlConnection, instruction);
            command.Execute();

            var oracleConnection = new OracleConnection("connection string for oracle server");
            instruction = "INSTRUCTION TO ORACLE SERVER";
            command = new DbCommand(oracleConnection, instruction);
            command.Execute();
        }
    }

    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new ArgumentNullException("connection", "Connection cannot be null.");
            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("instruction", "Instruction cannot be null of empty string.");
            _connection = connection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Executing instruction : " + _instruction);
            _connection.CloseConnection();
        }
    }

    public abstract class DbConnection
    {
        public string ConnectionString;
        public TimeSpan TimeOut = TimeSpan.FromSeconds(5);

        public DbConnection(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException("connectionString", "Connection String cannot be null.");
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }

    public class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL server : Opening connection : " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL server : Closing connection");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle server : Opening connection : " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle server : Closing connection");
        }
    }
}
