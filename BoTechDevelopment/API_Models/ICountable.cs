namespace BoTechDevelopment.API_Models
{
    public abstract class ICountable
    {
        public int ID { get => ID; set => setID(value); }
        private bool IsWritten = false;
        public void setID(int ID)
        {
            if(!IsWritten) this.ID = ID;
            IsWritten = true;
        }
    }
}
