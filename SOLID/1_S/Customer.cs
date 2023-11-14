namespace SOLID._1_S
{
    internal class Customer
    {

        public void Add()
        {
            //try-catch should be placed in presentation layer
            try
            {
                //add customer to database

            }
            catch (Exception e)
            {
                /*
                 * As per single responsibility principle Customer class shouldn't
                 * have the responsibility of error logging
                 */
                System.IO.File.WriteAllText(@"c:\errors.txt", e.Message);

                /*
                 * Instead above, we should user a separate class for error handling
                 * which should be called and assigned the responsibility instead.
                 */
                ErrorHandler eh = new ErrorHandler();
                eh.Handle(e);

                /*
                 * above code fulfills the SRP but we should avoid instantiating objects and try using DI instead. Because-
                 * Provides a layer of abstraction.
                 * Helps in Unit testing.
                 * Extending the application becomes easier.
                 * Helps to enable loose coupling, which is important in application programming.
                 */
            }
        }
    }
}
