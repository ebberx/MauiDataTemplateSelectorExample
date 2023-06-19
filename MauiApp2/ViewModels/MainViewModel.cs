namespace MauiApp2.ViewModels;

public class Fruit {
    public string Name { get; set; } = "Banana";
    public int Quantity { get; set; } = 2;
}

public class Animal
{
    public string Name { get; set; } = "Hyena";
    public string Sound { get; set; } = "huehuehuehue";
}

public partial class MainViewModel : BaseViewModel {
    [ObservableProperty]
    public List<Object> items = new List<Object>() {

        new Fruit { },
        new Fruit { Name = "Apple", Quantity = 2 },
        new Fruit { Name = "Pear", Quantity = 5 },
        new Fruit { Name = "Orange", Quantity = 3 },
        new Animal { Name = "Orangutan", Sound = "Me find banana, me eat banana" },
        new Animal { Name = "EASV Student", Sound = "Oh boy! I love UX design!" },
        new Animal { }
    };

}
