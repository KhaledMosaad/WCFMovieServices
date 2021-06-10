using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Movie.Services
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        List<Movie> GetAll();
        [OperationContract]
        Movie Add(Movie movie);
        [OperationContract]
        Movie Modify(Movie movie);

        [OperationContract]
        void Remove(int id);
    }
}
