using eTickets.Models;

namespace eTickets.Services
{
    public class ProducerServices : IProducerServices
    {
        private AppDbContext context;
        public ProducerServices(AppDbContext context) {
            this.context = context;
        }
        public void Add(Producer producer)
        {
            context.Producers.Add(producer);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producer> GetAll()
        {
            List<Producer> producers = context.Producers.ToList();
            return producers;
        }

        public Actor GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, Producer producer)
        {
            throw new NotImplementedException();
        }
    }
}
