using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public class Claims_Repository
    {
        private Queue<Claims> queue; 

        public Claims_Repository()
        {
            queue = new Queue<Claims>();
        }
        public void AddClaimtoQueue(Claims claim)
        {
            queue.Enqueue(claim);
        }
        public Claims GetNextClaim()
        {
            return queue.Dequeue();
        }
        public Queue<Claims> GetClaims()
        {
            return queue;
        }

        




    }

}
