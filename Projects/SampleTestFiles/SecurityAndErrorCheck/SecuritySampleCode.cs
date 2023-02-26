


public class SqlQueries
{
    public object UnsafeQuery(
       string connection, string name, string password)
    {
        if(string.IsNullOrWhiteSpace(connection))
            throw new ArgumentException("connection string required", nameof(connection));
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("username required", nameof(name));
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("password required", nameof(password));

        SqlConnection someConnection = new SqlConnection(connection);
        SqlCommand someCommand = new SqlCommand();
        someCommand.Connection = someConnection;

        someCommand.CommandText = "SELECT AccountNumber FROM Users " +
           "WHERE Username=@name AND Password=@password";

        someCommand.Parameters.Add("@name", SqlDbType.NChar).Value = name;
        someCommand.Parameters.Add("@password", SqlDbType.NChar).Value = password;

        someConnection.Open();
        object accountNumber = someCommand.ExecuteScalar();
        someConnection.Close();
        return accountNumber;
    }

    public object SaferQuery(
       string connection, string name, string password)
    {
        if (string.IsNullOrWhiteSpace(connection))
            throw new ArgumentException("connection string required", nameof(connection));
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("username required", nameof(name));
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("password required", nameof(password));

        SqlConnection someConnection = new SqlConnection(connection);
        SqlCommand someCommand = new SqlCommand();
        someCommand.Connection = someConnection;

        someCommand.Parameters.Add(
           "@username", SqlDbType.NChar).Value = name;
        someCommand.Parameters.Add(
           "@password", SqlDbType.NChar).Value = password;
        someCommand.CommandText = "SELECT AccountNumber FROM Users " +
           "WHERE Username=@username AND Password=@password";

        someConnection.Open();
        object accountNumber = someCommand.ExecuteScalar();
        someConnection.Close();
        return accountNumber;
    }
}