namespace MonitorObject
{
    public class MonitorObject
    {
        private object _object=new object();
        public void Action()
        {
            try
            {
                Monitor.Enter(_object);
                //Action
            }
            catch(Exception ex)
            {
                //place your exception logger here
            }
            finally
            {
                Monitor.Exit(_object);
            }
        }
    }
}
