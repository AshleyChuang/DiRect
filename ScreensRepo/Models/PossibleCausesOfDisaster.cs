using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.Models
{
    public class PossibleCausesOfDisaster
    {
        public List<string> causes;
        public PossibleCausesOfDisaster()
        {
            causes = new List<string>()
            {
                "雨量過大",
                "海水倒灌",
                "水庫洩洪",
                "排水不良",
                "抽水站故障",
                "抽水不及",
                "坡地崩塌災害",
                "上游過度開發",
                "地層下陷",
                "相對地勢低窪",
                "河水溢堤",
                "堤防潰決",
                "堤防施工缺口",
                "水門未關",
                "土石流災害引發",
                "排水道淤積",
                "河道淤積",
                "河道阻塞",
                "路堤效應",
                "道路施工",
                "地震災害",
                "缺乏整治",
                "其他"
            };
        }
        static PossibleCausesOfDisaster possiblecauses;
        public static PossibleCausesOfDisaster GetInstance()
        {
            if (possiblecauses == null)
                possiblecauses = new PossibleCausesOfDisaster();
            return possiblecauses;
        }
    }
}
