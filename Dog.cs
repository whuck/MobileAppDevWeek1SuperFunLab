namespace csharp
{
  public class Dog : Pet, ITalkable {
    private bool _friendly {get;set;}
    public Dog (bool friendly, string name) : base(name) {
      this._friendly = friendly;
    }
    public bool IsFriendly() {return _friendly;}
    public string Talk() {return "Bark";}
    public string GetName() {return this.Name;}
    public override string ToString() {return "Dog: "+"name="+Name+" friendly="+_friendly;}
  }
}