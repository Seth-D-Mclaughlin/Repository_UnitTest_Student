using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
    public class CandleRepository
    {
        private readonly List<Candle> _candles = new List<Candle>();
        private int _idCounter = default;
        // default - assigns whatever the default value is for the type specified.
        public bool Create(Candle candle)
        {
            if (candle is null)
            {
                return false;
            }

            // (++count) Incrementation must be carried out before assignment;
            // (count++) Incrementation must be carried out after assignment;
            candle.Id = ++_idCounter;

            _candles.Add(candle);

            return true;
        }
        public List<Candle> GetAll()
        {
            return _candles;
        }
        public Candle GetById(int id)
        {
            foreach (var candle in _candles)
            {
                if (candle.Id == id)
                {
                    return candle;
                }
            }
            return null;
        }
        public bool UpdateCandle(int id, Candle candle)
        {
            Candle existingCandle = this.GetById(id);
            if (existingCandle is null)
            {
                return false;
            }

            existingCandle.NetWeightOunces = candle.NetWeightOunces;
            existingCandle.Scent = candle.Scent;

            return true;
        }
        public bool Delete(int id)
        {
            Candle existingCandle = this.GetById(id);
            if (existingCandle is null)
            {
                return false;
            }
            int initialCount = _candles.Count;
            _candles.Remove(existingCandle);

            return initialCount > _candles.Count;
        }
    }
}
