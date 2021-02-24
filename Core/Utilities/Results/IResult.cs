using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } //sadece oku , operasyon başarılı mı başarısız mı.
        string Message { get; } // ekrana verilecek mesaj 
    }
}
