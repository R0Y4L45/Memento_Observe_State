public class Originator
{

    private String state;

    public void setState(String state)
    {
        this.state = state;
    }

    public String getState()
    {
        return state;
    }

    public Memento saveStateToMemento()
    {
        return new Memento(state);
    }

    public void getStateFromMemento(Memento Memento)
    {
        state = Memento.getState();
    }
}// End of the Originator class.  


//This is a class.  

public class Memento
{

    private String state;

    public Memento(String state)
    {
        this.state=state;
    }
    public String getState()
    {
        return state;
    }

}// End of the 


//This is a class.  



public class Caretaker
{

    private List<Memento> mementoList = new List<Memento>();

    public void Add(Memento state)
    {
        mementoList.Add(state);
    }

    public Memento Get(int index)
    {
        return mementoList[index];
    }

}// End of the Caretaker class.


//This is a class.  


public class MementoPatternDemo
{
    public static void Main()
    {

        Originator originator = new Originator();

        Caretaker careTaker = new Caretaker();

        originator.setState("State #1");
        careTaker.Add(originator.saveStateToMemento());
        originator.setState("State #2");
        careTaker.Add(originator.saveStateToMemento());
        originator.setState("State #3");
        careTaker.Add(originator.saveStateToMemento());
        originator.setState("State #4");

        Console.WriteLine("Current State: " + originator.getState());
        originator.getStateFromMemento(careTaker.Get(0));
        Console.WriteLine("First saved State: " + originator.getState());
        originator.getStateFromMemento(careTaker.Get(1));
        Console.WriteLine("Second saved State: " + originator.getState());
        originator.getStateFromMemento(careTaker.Get(2));
        Console.WriteLine("Third saved State: " + originator.getState());
    }

}
// End of the MementoPatternDemo class.  