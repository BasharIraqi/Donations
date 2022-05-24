namespace Donations
{
    public class AllDonations :IAllDonations
    {

        private int CountDonations;

        public void SumDon(int don)
        {
            CountDonations+=don;
        }

        public int AllDon()
        {
            return CountDonations;
        }
    }
}
