using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Istifadechi birinci defe run edibse 
//adini, cekisini daxil edecek. 
// 16.06.2024
// Dundelik Norma: 4 Lt
// Bugun: 0.7 lt
// 1. Su ich => ne qeder su ichdiyini daxil edir
// 2. Tarixche(History) 
// 3. Gunu Bitir => Tebrikler siz gundelik meqsede chatmisiz. | Chox az su ichmisiz diqqetli olun
// 4. Chixish

// 2. Tarixche(History)  => Taxir: ichdiyi su miqdari
//			    13.06.2024: 0.7lt
//			    14.06.2024: 1.4lt
namespace F
{
    public class User
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public DateTime Current { get; set; }
        public float WaterNorm { get; set; }
        public float Litr { get; set; }
        public List<ListHisstory> History{ get; set; }
    }
}
