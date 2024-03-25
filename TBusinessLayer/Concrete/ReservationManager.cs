using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TDataAccesLayer.Abstract;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Concrete
{
    public class ReservationManager : IReservatonService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
           return  _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public void TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetlist()
        {
            return _reservationDal.GetList();
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }

        Reservation IGenericService<Reservation>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
