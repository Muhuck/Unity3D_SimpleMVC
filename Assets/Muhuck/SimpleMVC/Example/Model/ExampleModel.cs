namespace Muhuck.MVC
{
    public class ExampleModel : Model
    {
        public int count {get; private set;}

        public void AddCount(){
            count++;
            NotifyChanged();
        }
    }
}