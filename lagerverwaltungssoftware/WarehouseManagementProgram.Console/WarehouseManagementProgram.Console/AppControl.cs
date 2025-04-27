public class AppControl
{
    //temporarily save current Dataset in this class
    Dataset dataset;

    public void RunApp()
    {
        InitApp();

    }

    private void InitApp()
    {
        //firstly user is prompted to mount a dataset
        dataset = UserInterface.MountDataSet();

        UserInterface.PrintDataset(dataset);
    }
}

