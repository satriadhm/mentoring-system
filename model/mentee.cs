using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    enum JenisKelamin
    {
        PRIA,
        WANITA
    }

    enum EducationLevel
    {
        SD,
        SMP,
        SMA
    }
    internal class mentee
    {
        private int Id;
        private string namaLengkap;
        private JenisKelamin jenisKelamin;
        private int umur;
        private EducationLevel pendidikanTerakhir;

    }
}
