﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public record YearMonth(int Year, int Month) {
            
        public bool Is21Century => 2001 <= Year && Year <= 2100;

        public YearMonth AddOneMonth() {
            if (Month < 12) {
                return new YearMonth(Year,Month + 1);
            } else {
                return new YearMonth(Year + 1,1);
            }
        }
        public override string ToString() => $"{Year}年 {Month}月";
         

    }
}
  