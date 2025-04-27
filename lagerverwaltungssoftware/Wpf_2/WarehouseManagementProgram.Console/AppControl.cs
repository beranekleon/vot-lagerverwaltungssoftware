public class AppControl
{
    public void RunApp(string[] args)
    {
        //check if args is empty
        if (args.Length == 0)
        {
            //if no args are given, run data insert logic
            //if there is no data inserted, create new dataset
            UserInterface.MountDataSet();
        }

        //if args (data) are given, print data, then action menu
    }
}

