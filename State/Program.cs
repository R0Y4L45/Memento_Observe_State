//This is an interface.  

public interface Connection
{

    void Open();
    void Close();
    void Log();
    void Update();
}

// End of the Connection interface. 


//This is a class.  
public class Accounting : Connection
{

    public void Open()
    {
        Console.WriteLine("open database for accounting");
    }

    public void Close()
    {
        Console.WriteLine("close the database");
    }

    public void Log()
    {
        Console.WriteLine("log activities");
    }

    public void Update()
    {
        Console.WriteLine("Accounting has been updated");
    }

}// End of the Accounting class.


//This is a class.  
public class Sales : Connection
{

    public void Open()
    {
        Console.WriteLine("open database for sales");
    }
    public void Close()
    {
        Console.WriteLine("close the database");
    }

    public void Log()
    {
        Console.WriteLine("log activities");
    }

    public void Update()
    {
        Console.WriteLine("Sales has been updated");
    }

}// End of the Sales class.  



//This is a class.  


public class Management : Connection
{
       public void Open()
{
    Console.WriteLine("open database for Management");
}
       public void Close()
{
    Console.WriteLine("close the database");
}

       public void Log()
{
    Console.WriteLine("log activities");
}

       public void Update()
{
    Console.WriteLine("Management has been updated");
}  
  
}  
 // End of the Management class.  


//This is a class.  
  
public class Controller
{

    public static Accounting? acct;
    public static Sales? sales;
    public static Management? management;

    private static Connection? con;

    Controller()
    {
        acct = new Accounting();
        sales = new Sales();
        management = new Management();
    }

    public void SetAccountingConnection()
    {
        con = acct;
    }
    public void SetSalesConnection()
    {
        con  = sales;
    }
    public void SetManagementConnection()
    {
        con  = management;
    }
    public void Open()
    {
        con.Open();
    }
    public void Close()
    {
        con.Close();
    }
    public void Log()
    {
        con.Log();
    }
    public void Update()
    {
        con.Update();
    }


}// End of the Controller class.  


//This is a class.  


public class StatePatternDemo
{

    public Controller controller;
    StatePatternDemo(string con)
    {
        controller = new Controller();
        //the following trigger should be made by the user  
        if (con == "management")
            controller.SetManagementConnection();
        if (con == "sales")
            controller.SetSalesConnection();
        if (con == "accounting")
            controller.SetAccountingConnection();
        controller.Open();
        controller.Log();
        controller.Close();
        controller.Update();
    }


    public static void Main(string args)
    {

        new StatePatternDemo(args[0].ToString());

    }

}

// End of the StatePatternDemo class. 