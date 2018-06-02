namespace Fonet.Render.Pdf.Fonts {
    internal class ZapfDingbats : Base14Font {
        private static readonly int[] CodePointWidths;

        private static readonly CodePointMapping DefaultMapping
            = CodePointMapping.GetMapping("ZapfDingbatsEncoding");

        public ZapfDingbats()
            : base("ZapfDingbats", null, 820, 802, -143, 32, 255, CodePointWidths, DefaultMapping) {}

        static ZapfDingbats() {
            CodePointWidths = new int[256];
            CodePointWidths[0x0020] = 278;
            CodePointWidths[0x0021] = 974;
            CodePointWidths[0x0022] = 961;
            CodePointWidths[0x0023] = 974;
            CodePointWidths[0x0024] = 980;
            CodePointWidths[0x0025] = 719;
            CodePointWidths[0x0026] = 789;
            CodePointWidths[0x0027] = 790;
            CodePointWidths[0x0028] = 791;
            CodePointWidths[0x0029] = 690;
            CodePointWidths[0x002A] = 960;
            CodePointWidths[0x002B] = 939;
            CodePointWidths[0x002C] = 549;
            CodePointWidths[0x002D] = 855;
            CodePointWidths[0x002E] = 911;
            CodePointWidths[0x002F] = 933;
            CodePointWidths[0x0030] = 911;
            CodePointWidths[0x0031] = 945;
            CodePointWidths[0x0032] = 974;
            CodePointWidths[0x0033] = 755;
            CodePointWidths[0x0034] = 846;
            CodePointWidths[0x0035] = 762;
            CodePointWidths[0x0036] = 761;
            CodePointWidths[0x0037] = 571;
            CodePointWidths[0x0038] = 677;
            CodePointWidths[0x0039] = 763;
            CodePointWidths[0x003A] = 760;
            CodePointWidths[0x003B] = 759;
            CodePointWidths[0x003C] = 754;
            CodePointWidths[0x003D] = 494;
            CodePointWidths[0x003E] = 552;
            CodePointWidths[0x003F] = 537;
            CodePointWidths[0x0040] = 577;
            CodePointWidths[0x0041] = 692;
            CodePointWidths[0x0042] = 786;
            CodePointWidths[0x0043] = 788;
            CodePointWidths[0x0044] = 788;
            CodePointWidths[0x0045] = 790;
            CodePointWidths[0x0046] = 793;
            CodePointWidths[0x0047] = 794;
            CodePointWidths[0x0048] = 816;
            CodePointWidths[0x0049] = 823;
            CodePointWidths[0x004A] = 789;
            CodePointWidths[0x004B] = 841;
            CodePointWidths[0x004C] = 823;
            CodePointWidths[0x004D] = 833;
            CodePointWidths[0x004E] = 816;
            CodePointWidths[0x004F] = 831;
            CodePointWidths[0x0050] = 923;
            CodePointWidths[0x0051] = 744;
            CodePointWidths[0x0052] = 723;
            CodePointWidths[0x0053] = 749;
            CodePointWidths[0x0054] = 790;
            CodePointWidths[0x0055] = 792;
            CodePointWidths[0x0056] = 695;
            CodePointWidths[0x0057] = 776;
            CodePointWidths[0x0058] = 768;
            CodePointWidths[0x0059] = 792;
            CodePointWidths[0x005A] = 759;
            CodePointWidths[0x005B] = 707;
            CodePointWidths[0x005C] = 708;
            CodePointWidths[0x005D] = 682;
            CodePointWidths[0x005E] = 701;
            CodePointWidths[0x005F] = 826;
            CodePointWidths[0x0060] = 815;
            CodePointWidths[0x0061] = 789;
            CodePointWidths[0x0062] = 789;
            CodePointWidths[0x0063] = 707;
            CodePointWidths[0x0064] = 687;
            CodePointWidths[0x0065] = 696;
            CodePointWidths[0x0066] = 689;
            CodePointWidths[0x0067] = 786;
            CodePointWidths[0x0068] = 787;
            CodePointWidths[0x0069] = 713;
            CodePointWidths[0x006A] = 791;
            CodePointWidths[0x006B] = 785;
            CodePointWidths[0x006C] = 791;
            CodePointWidths[0x006D] = 873;
            CodePointWidths[0x006E] = 761;
            CodePointWidths[0x006F] = 762;
            CodePointWidths[0x0070] = 762;
            CodePointWidths[0x0071] = 759;
            CodePointWidths[0x0072] = 759;
            CodePointWidths[0x0073] = 892;
            CodePointWidths[0x0074] = 892;
            CodePointWidths[0x0075] = 788;
            CodePointWidths[0x0076] = 784;
            CodePointWidths[0x0077] = 438;
            CodePointWidths[0x0078] = 138;
            CodePointWidths[0x0079] = 277;
            CodePointWidths[0x007A] = 415;
            CodePointWidths[0x007B] = 392;
            CodePointWidths[0x007C] = 392;
            CodePointWidths[0x007D] = 668;
            CodePointWidths[0x007E] = 668;
            CodePointWidths[0x00A1] = 732;
            CodePointWidths[0x00A2] = 544;
            CodePointWidths[0x00A3] = 544;
            CodePointWidths[0x00A4] = 910;
            CodePointWidths[0x00A5] = 667;
            CodePointWidths[0x00A6] = 760;
            CodePointWidths[0x00A7] = 760;
            CodePointWidths[0x00AC] = 788;
            CodePointWidths[0x00AD] = 788;
            CodePointWidths[0x00AE] = 788;
            CodePointWidths[0x00AF] = 788;
            CodePointWidths[0x00B0] = 788;
            CodePointWidths[0x00B1] = 788;
            CodePointWidths[0x00B2] = 788;
            CodePointWidths[0x00B3] = 788;
            CodePointWidths[0x00B4] = 788;
            CodePointWidths[0x00B5] = 788;
            CodePointWidths[0x00B6] = 788;
            CodePointWidths[0x00B7] = 788;
            CodePointWidths[0x00B8] = 788;
            CodePointWidths[0x00B9] = 788;
            CodePointWidths[0x00BA] = 788;
            CodePointWidths[0x00BB] = 788;
            CodePointWidths[0x00BC] = 788;
            CodePointWidths[0x00BD] = 788;
            CodePointWidths[0x00BE] = 788;
            CodePointWidths[0x00BF] = 788;
            CodePointWidths[0x00C0] = 788;
            CodePointWidths[0x00C1] = 788;
            CodePointWidths[0x00C2] = 788;
            CodePointWidths[0x00C3] = 788;
            CodePointWidths[0x00C4] = 788;
            CodePointWidths[0x00C5] = 788;
            CodePointWidths[0x00C6] = 788;
            CodePointWidths[0x00C7] = 788;
            CodePointWidths[0x00C8] = 788;
            CodePointWidths[0x00C9] = 788;
            CodePointWidths[0x00CA] = 788;
            CodePointWidths[0x00CB] = 788;
            CodePointWidths[0x00CC] = 788;
            CodePointWidths[0x00CD] = 788;
            CodePointWidths[0x00CE] = 788;
            CodePointWidths[0x00CF] = 788;
            CodePointWidths[0x00D0] = 788;
            CodePointWidths[0x00D1] = 788;
            CodePointWidths[0x00D2] = 788;
            CodePointWidths[0x00D3] = 788;
            CodePointWidths[0x00D4] = 894;
            CodePointWidths[0x00D7] = 458;
            CodePointWidths[0x00D8] = 748;
            CodePointWidths[0x00D9] = 924;
            CodePointWidths[0x00DA] = 748;
            CodePointWidths[0x00DB] = 918;
            CodePointWidths[0x00DC] = 927;
            CodePointWidths[0x00DD] = 928;
            CodePointWidths[0x00DE] = 928;
            CodePointWidths[0x00DF] = 834;
            CodePointWidths[0x00E0] = 873;
            CodePointWidths[0x00E1] = 828;
            CodePointWidths[0x00E2] = 924;
            CodePointWidths[0x00E3] = 924;
            CodePointWidths[0x00E4] = 917;
            CodePointWidths[0x00E5] = 930;
            CodePointWidths[0x00E6] = 931;
            CodePointWidths[0x00E7] = 463;
            CodePointWidths[0x00E8] = 883;
            CodePointWidths[0x00E9] = 836;
            CodePointWidths[0x00EA] = 836;
            CodePointWidths[0x00EB] = 867;
            CodePointWidths[0x00EC] = 867;
            CodePointWidths[0x00ED] = 696;
            CodePointWidths[0x00EE] = 696;
            CodePointWidths[0x00EF] = 874;
            CodePointWidths[0x00F1] = 874;
            CodePointWidths[0x00F2] = 760;
            CodePointWidths[0x00F3] = 946;
            CodePointWidths[0x00F4] = 771;
            CodePointWidths[0x00F5] = 865;
            CodePointWidths[0x00F6] = 771;
            CodePointWidths[0x00F7] = 888;
            CodePointWidths[0x00F8] = 967;
            CodePointWidths[0x00F9] = 888;
            CodePointWidths[0x00FA] = 831;
            CodePointWidths[0x00FB] = 873;
            CodePointWidths[0x00FC] = 927;
            CodePointWidths[0x00FD] = 970;
            CodePointWidths[0x00FE] = 918;
            CodePointWidths[0x0089] = 410;
            CodePointWidths[0x0087] = 509;
            CodePointWidths[0x008C] = 334;
            CodePointWidths[0x0086] = 509;
            CodePointWidths[0x0080] = 390;
            CodePointWidths[0x008A] = 234;
            CodePointWidths[0x0084] = 276;
            CodePointWidths[0x0081] = 390;
            CodePointWidths[0x0088] = 410;
            CodePointWidths[0x0083] = 317;
            CodePointWidths[0x0082] = 317;
            CodePointWidths[0x0085] = 276;
            CodePointWidths[0x008D] = 334;
            CodePointWidths[0x008B] = 234;
        }
    }
}