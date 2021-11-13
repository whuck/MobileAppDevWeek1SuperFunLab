namespace csharp
{
  public class Cat : Pet, ITalkable {
    private int _mousesKilled {get;set;}
    public Cat (int mousesKilled, string name) : base(name) {
      this._mousesKilled = mousesKilled;
    }
    public int GetMousesKilled() {return _mousesKilled;}
    public void AddMouse() {_mousesKilled++;}
    public string Talk() {return "meow";}
    public string GetName() {return this.Name;}
    public override string ToString() {return "Cat: "+"name="+Name+" mousesKilled="+_mousesKilled;}
  }
}