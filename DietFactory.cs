class DietFactory
{
    public IBasicDiet GetMenu(string dietName)
    {
        switch (dietName)
        { 
        case "ve":
            return new Vegan();
        case "vg":
            return new Vegetarian();
        case "o":
            return new Omnivore();
        default:
            return null;
        }
    }
}