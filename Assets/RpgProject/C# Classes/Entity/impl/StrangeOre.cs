class StrangeOre : ore 
{
    public Item item;
    public StrangeOre() :base("Strange Ore", 150) { }
    public override void Die()
    {
        new drop(gameObject.transform.position, Instantiate(item)).createNewDrop();
        Destroy(gameObject);
    }
}