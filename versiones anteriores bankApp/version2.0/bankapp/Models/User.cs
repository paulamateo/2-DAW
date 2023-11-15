namespace Models;

public class User {
    public string Name {get; set;}
    public string? Lastname {get; set;}
    public string? NIF {get; set;}
    public User(string name, string lastname) {
        Name = name;
        Lastname = lastname;
    }

    public User() {}

    public override string ToString() {
        return (Name ?? "NoName") + " " + (Lastname ?? "NoLastName") + NIF;
    }
}