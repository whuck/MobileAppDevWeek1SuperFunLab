namespace csharp
{
  public class Teacher : Person, ITalkable {
    private int _age {get;set;}
    public Teacher (int age, string name) : base(name) {
      this._age = age;
    }
    public string GetName() {return this.Name;}
    public string Talk() {return "Don't forget to do the assigned reading!";}
  }
}