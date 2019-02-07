using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomNewProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Mah, SpeedInf, SoundSpeed, Alpha, Epsilon, RootChord, EndChord, LengthSkosa, LengthLA, FullWingspan, Wingspan, DiamMidel, TailLength, SweepAngleFront, SweepAngle05, MidelArea, EndArea, RoInf, NuInf, TiltAngleFront;
        public double WingConstriction, WingElongetion, AlphaDot, Lambda1, CyAlpha, Cy, Graph, x;
        public double a, b, c, d, ee, f, g, h, i;
        public double TiltAngleFrontTail, TailConstriction, TailElongation, TailWingspanFull, MahTail, CyAlphaTail, nTail, Em;
        public double Bk, CrHead, CnHead, mzHead, CxHead, CyHead;
        public int ii, jj, kk;
        public double AA, BB, Kx, EpsOp, XX, Etta, x_, TailDiam, CyAlphaHead, CyaAlphaFuselage, lop, Kt, Kkr, Kaa;
        public double WingArea, TailArea, CyAlphaFKr, CyaFKr, EpsAlpha, KtTail, KkrTail, CyFull;
        public double XcHead, XcWing, XcTail, mz, Ccd, Xcd;
        public double Cxv, Cxi, Cxotr, Cxx, Cxd, Ckoef, CylinderElongation, EndElongation, CylinderLength, K1, Cx, CxKor;
        public double CxWing, CxTail, Cxv0Wing, Cxv0Tail, CxxWing, CxxTail, CxiCxvWing, CxiCxvTail, C_Wing, C_Tail, K2Wing, K2Tail, Xc_Wing, Xc_Tail, ReWing, ReTail;

        // int[, ,] ArrKoef = new int[5, 6, 12];
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mah = Convert.ToDouble(TxtMah.Text);
            SoundSpeed = Convert.ToDouble(TxtSoundSpeed.Text);
            SpeedInf = Mah * SoundSpeed;
            Alpha = Convert.ToDouble(TxtAlpha.Text);
            Epsilon = Convert.ToDouble(TxtEpsilon.Text);
            RootChord = Convert.ToDouble(TxtRootChord.Text);
            EndChord = Convert.ToDouble(TxtEndChord.Text);
            LengthSkosa = Convert.ToDouble(TxtLengthSkosa.Text);
            LengthLA = Convert.ToDouble(TxtLengthLA.Text);
            FullWingspan = Convert.ToDouble(TxtWingspan.Text);
            DiamMidel = Convert.ToDouble(TxtDiamMidel.Text);
            Wingspan = FullWingspan - DiamMidel;
            TailLength = Convert.ToDouble(TxtTailLength.Text);
            SweepAngleFront = Convert.ToDouble(TxtSweepAngleFront.Text);
            SweepAngle05 = Convert.ToDouble(TxtSweepAngle05.Text);
            MidelArea = (Math.PI * DiamMidel * DiamMidel) / 4;
            EndArea = Convert.ToDouble(TxtEndArea.Text);
            RoInf = Convert.ToDouble(TxtRoInf.Text);
            NuInf = Convert.ToDouble(TxtNuInf.Text);
            TiltAngleFront = Convert.ToDouble(TxtTiltAngleFront.Text);
            TiltAngleFrontTail = Convert.ToDouble(TxtTiltAngleFrontTail.Text);
            TailConstriction = Convert.ToDouble(TxtTailConstriction.Text);
            TailElongation = Convert.ToDouble(TxtTailConstriction.Text);
            TailWingspanFull = Convert.ToDouble(TxtTailWingspanFull.Text);
            Bk = Convert.ToDouble(TxtBk.Text);
            EpsOp = Convert.ToDouble(TxtEpsOp.Text);
            XX = Convert.ToDouble(TxtXX.Text);
            TailDiam = Convert.ToDouble(TxtTailDiam.Text);
            WingArea = Convert.ToDouble(TxtWingArea.Text);
            TailArea = Convert.ToDouble(TxtTailArea.Text);
            CylinderLength = Convert.ToDouble(TxtCylinderLength.Text);
            C_Tail = Convert.ToDouble(TxtC_Tail.Text);
            C_Wing = Convert.ToDouble(TxtC_Wing.Text);



            
            
            //РАСЧЕТ КОЭФФИЦИЕНТА ПОДЪЕМНОЙ СИЛЫ ЛА
            //Расчет коэффициента подъемной силы крыла



            WingConstriction = RootChord / EndChord;
            WingElongetion = 2 * Wingspan / (RootChord + EndChord);

         //   AlphaDot = Math.Sqrt(Mah * Mah - 1);
            Lambda1 = WingElongetion * Math.Tan(SweepAngle05);

            if (Mah < 1)
            {
                x = Math.Sqrt(1 - (Mah * Mah))*(-1);
            }
            else
            {
                x = Math.Sqrt(Mah * Mah - 1);
            }





            if (WingConstriction < 1.5)
            {
                if (Lambda1 <= 0.5)
                {
                        a=1.57207346223180E+00;
                        b=1.01617968765504E-01;
                        c=-5.82196835897329E-02;
                        d=-8.99696493151266E-03;
                        ee = 0.001631468808601850;
                        f= 2.20898423483105E-04;
                        g=-2.61857158326035E-05;
                        h=-1.72791282789330E-06;
                        i = 1.76553633139500E-07;
                }
                if (Lambda1>0.5&&Lambda1<=2) 
                {
                        a = 1.561144945801932E+00;
                        b = 1.121056450861312E-01;
                        c = -5.990231934086197E-02;
                        d = -9.415736732739570E-03;
                        ee = 1.758946741731330E-03;
                        f = 2.305570818054232E-04;
                        g = -2.880746020289926E-05;
                        h = -1.770477043534691E-06;
                        i = 1.895977811353665E-07;
                }
                if (Lambda1 > 2 && Lambda1 <= 4)
                {
                        a = 1.265701011819885E+00;
                        b = 1.488968430682144E-01;
                        c = -2.834609169434724E-02;
                        d = -1.290970543068959E-02;
                        ee = 5.575576062478976E-04;
                        f = 4.107866332680469E-04;
                        g = -1.836301305099860E-05;
                        h = -4.620259241196320E-06;
                        i = 3.129607157788380E-07;
                }
                if (Lambda1 > 4)
                {
                        a = 8.896247763727682E-01;
                        b = 7.683535596825246E-02;
                        c = -2.808563464884688E-03;
                        d = -2.919730350573864E-03;
                        ee = -1.612437953164346E-04;
                        f = 6.370307527863055E-05;
                        g = 7.918556757759866E-07;
                        h = -6.671613571909299E-07;
                        i = 3.078854274907363E-08;
                }

            }
            if (WingConstriction > 1.5 && WingConstriction <= 4)
            {
                if (Lambda1 <= 0.5)
                {
                        a = 1.581886483839633E+00;
                        b = 8.520862778605151E-02;
                        c = -6.720425463723623E-02;
                        d = -8.606644788597028E-03;
                        ee = 2.196120831970197E-03;
                        f = 2.307466880890107E-04;
                        g = -3.702404108914020E-05;
                        h = -1.862268442373860E-06;
                        i = 2.388113354378506E-07;
                }
                if (Lambda1 > 0.5 && Lambda1 <= 2)
                {
                        a = 1.557389335464914E+00;
                        b = 1.018268159301407E-01;
                        c = -6.478965177298493E-02;
                        d = -8.964402706973821E-03;
                        ee = 2.111155761143465E-03;
                        f = 2.232619989393977E-04;
                        g = -3.523775802079209E-05;
                        h = -1.605902872504157E-06;
                        i = 2.111951878484825E-07;
                }
                if (Lambda1 > 2 && Lambda1 <= 4)
                {
                        a = 1.271720740371352E+00;
                        b = 1.201885723320373E-01;
                        c = -2.663955373737905E-02;
                        d = -9.148746550813981E-03;
                        ee = 5.359807022592623E-04;
                        f = 2.636857480739384E-04;
                        g = -1.404437370240679E-05;
                        h = -2.748692090045094E-06;
                        i = 1.953415751035243E-07;
                }
                if (Lambda1 > 4)
                {
                        a = 8.936601624216546E-01;
                        b = 3.159815502775093E-02;
                        c = -9.751415389285131E-03;
                        d = -5.788538955688448E-04;
                        ee = 1.199674598270217E-04;
                        f = 2.649557249173543E-06;
                        g = -7.222121075378506E-07;
                        h = -4.876195041525107E-08;
                        i = 5.325172841389604E-09;
                }
            }

            if (WingConstriction > 4 && WingConstriction <= 10)
            {
                if (Lambda1 <= 0.5)
                {
                        a = 1.638237968927702E+00;
                        b = 1.269772612854694E-01;
                        c = -6.297820020362809E-02;
                        d = -1.092516664450765E-02;
                        ee = 1.862867831661377E-03;
                        f = 3.016517136929345E-04;
                        g = -3.319998842654747E-05;
                        h = -2.805431270962188E-06;
                        i = 2.712544161225042E-07;
                }
                if (Lambda1 > 0.5 && Lambda1 <= 2)
                {
                        a = 1.668778507518121E+00;
                        b = 2.233691026807999E-01;
                        c = -6.240600156491510E-02;
                        d = -2.137204331784957E-02;
                        ee = 1.887704996738088E-03;
                        f = 6.895367692794351E-04;
                        g = -4.706542837404363E-05;
                        h = -7.593218542667136E-06;
                        i = 5.929347656610181E-07;
                }
                if (Lambda1 > 2 && Lambda1 <= 4)
                {
                        a = 1.285668492927275E+00;
                        b = 1.286876034568862E-01;
                        c = -3.361579425180322E-02;
                        d = -9.178590854962124E-03;
                        ee = 8.372666004673421E-04;
                        f = 2.444065882239192E-04;
                        g = -1.708553636610637E-05;
                        h = -2.357957247157944E-06;
                        i = 1.818224071286282E-07;


                }
                if (Lambda1 > 4)
                {
                        a = 8.724408727087307E-01;
                        b = 3.623290533042821E-02;
                        c = -5.668895449060653E-03;
                        d = -7.480965035938134E-04;
                        ee = 2.126833952082676E-06;
                        f = -7.041415844435407E-06;
                        g = 6.264752248720833E-07;
                        h = 3.030097444089905E-07;
                        i = -2.489329725460230E-08;
                }
            }
            if (WingConstriction > 10)
            {
                if (Lambda1 <= 0.5)
                {
                        a = 1.512224723561096E+00;
                        b = 3.196620451881492E-02;
                        c = -5.963885102510694E-02;
                        d = -1.363215661149546E-03;
                        ee = 1.829233474514031E-03;
                        f = -5.389602741500682E-05;
                        g = -2.146418853550571E-05;
                        h = 1.672395947082018E-06;
                        i = -2.224192013816661E-08;
                }
                if (Lambda1 > 0.5 && Lambda1 <= 2)
                {
                        a = 1.588596408221656E+00;
                        b = 8.324512942262825E-02;
                        c = -7.323100084014067E-02;
                        d = -5.550608338883076E-03;
                        ee = 2.550147027470772E-03;
                        f = 4.865568608076670E-05;
                        g = -3.644346391003309E-05;
                        h = 1.063002353631498E-06;
                        i = 6.365021819135647E-08;
                }
                if (Lambda1 > 2 && Lambda1 <= 4)
                {
                        a = 1.202276527518587E+00;
                        b = 2.384654200803321E-02;
                        c = -3.691371531959595E-02;
                        d = 3.317653626448408E-04;
                        ee = 1.107778064035000E-03;
                        f = -9.477427687618029E-05;
                        g = -1.079227461822557E-05;
                        h = 1.879780516876414E-06;
                        i = -7.231407080310015E-08;
                }
                if (Lambda1 > 4)
                {
                        a = 9.052629059300628E-01;
                        b = 2.562432472359311E-02;
                        c = -1.297013217114494E-02;
                        d = -2.658977267448416E-04;
                        ee = 2.728437494928859E-04;
                        f = -1.189841356707597E-05;
                        g = -2.451389760727241E-06;
                        h = 2.213766515952476E-07;
                        i = -3.712749995090702E-09;
                }
            }

            Graph = a + b * x + c * Math.Pow(x, 2) + d * Math.Pow(x, 3) + ee * Math.Pow(x, 4) + f * Math.Pow(x, 5) + g * Math.Pow(x, 6) + h * Math.Pow(x, 7) + i * Math.Pow(x, 8);

            CyAlpha = Graph * WingElongetion;
            Cy = CyAlpha * Alpha;


            //Расчет коэффициента подъемной силы изолированных рулей

            MahTail = 0.95 * Mah;
            if (TiltAngleFrontTail > Math.Asin(1 / MahTail))
            {
                CyAlphaTail = 4 / Math.Sqrt(MahTail * MahTail - 1);
            }
            else
            {
                nTail = Math.Tan(Math.PI - TiltAngleFrontTail) / Math.Sqrt(MahTail * MahTail - 1);
                if (1 / nTail >= 0 && 1 / nTail < 0.2) Em = 1 + ((0.05 / 0.2) * ((1 / nTail) - 0));
                if (1 / nTail >= 0.2 && 1 / nTail < 0.4) Em = 1.05 + ((0.09 / 0.2) * ((1 / nTail) - 0.2));
                if (1 / nTail >= 0.4 && 1 / nTail < 0.6) Em = 1.14 + ((0.14 / 0.2) * ((1 / nTail) - 0.4));
                if (1 / nTail >= 0.6 && 1 / nTail < 0.8) Em = 1.28 + ((0.14 / 0.2) * ((1 / nTail) - 0.6));
                if (1 / nTail >= 0.8 && 1 / nTail < 1) Em = 1.42 + ((0.15 / 0.2) * ((1 / nTail) - 0.8));

                CyAlphaTail = 2 / (Math.Tan(Math.PI - TiltAngleFrontTail) * Em);
            }

            //Расчет коэффициента подъемной силы головной части

            
            double[, ,] ArrKoef = new double[5, 7, 12] {{{0.1046, 0, 0, 0.0875, 0, 0, 0.0748, 0, 0, 0.0698, 0, 0},
{0.104, 0.0802, 0.0535, 0.0876, 0.0801, 0.0534, 0.0757, 0.0814, 0.0543, 0.071, 0.0627, 0.0551},
{0.1041, 0.0803, 0.0536, 0.0881, 0.1625, 0.1083, 0.0785, 0.1645, 0.1097, 0.0746, 0.1658, 0.1106},
{0.1042, 0.0804, 0.0537, 0.0882, 0.1626, 0.1084, 0.0831, 0.2508, 0.1672, 0.0805, 0.2506, 0.167},
{0.1042, 0.0804, 0.0537, 0.0882, 0.1626, 0.1084, 0.0831, 0.2508, 0.1672, 0.0805, 0.2506, 0.167},
{0.1042, 0.0804, 0.0537, 0.0882, 0.1626, 0.1084, 0.0831, 0.2508, 0.1672, 0.0805, 0.2506, 0.167},
{0.1042, 0.0804, 0.0537, 0.0882, 0.1626, 0.1084, 0.0831, 0.2508, 0.1672, 0.0805, 0.2506, 0.167}},
            {{0.2024, 0, 0, 0.1732, 0, 0, 0.1542, 0, 0, 0.1478, 0, 0},
{0.20195, 0.07625, 0.05085, 0.1742, 0.0775, 0.05165, 0.15615, 0.0793, 0.05285, 0.14985, 0.0802, 0.05355},
{0.2015, 0.1525, 0.1017, 0.1752, 0.155, 0.1033, 0.1581, 0.1586, 0.1057, 0.1519, 0.1604, 0.1071},
{0.2015, 0.17935, 0.15395, 0.1783, 0.2346, 0.1564, 0.16395, 0.23745, 0.15825, 0.15835, 0.23895, 0.1594},
{0.2015, 0.2062, 0.2062, 0.1814, 0.3142, 0.2095, 0.1698, 0.3163, 0.2108, 0.1648, 0.3175, 0.2117},
{0.2015, 0.2062, 0.2062, 0.1814, 0.3142, 0.2095, 0.1698, 0.3163, 0.2108, 0.1648, 0.3175, 0.2117},
{0.2015, 0.2062, 0.2062, 0.1814, 0.3142, 0.2095, 0.1698, 0.3163, 0.2108, 0.1648, 0.3175, 0.2117}},
            {{0.3256, 0, 0, 0.2843, 0, 0, 0.2605, 0, 0, 0.2532, 0, 0},
{0.32545, 0.07275, 0.0478, 0.28525, 0.07385, 0.04905, 0.26185, 0.0756, 0.0504, 0.25445, 0.07655, 0.05105},
{0.3253, 0.1455, 0.0956, 0.2862, 0.1477, 0.0981, 0.2632, 0.1512, 0.1008, 0.2557, 0.1531, 0.1021},
{0.32485, 0.21665, 0.14375, 0.28905, 0.2204, 0.14675, 0.2675, 0.22485, 0.1499, 0.2601, 0.22725, 0.1515},
{0.3244, 0.2878, 0.1919, 0.2919, 0.2931, 0.1954, 0.2718, 0.2985, 0.199, 0.2645, 0.3014, 0.2009},
{0.3245, 0.2879, 0.192, 0.3015, 0.4374, 0.2916, 0.2875, 0.4385, 0.2923, 0.2816, 0.4396, 0.293},
{0.3245, 0.2879, 0.192, 0.3015, 0.4374, 0.2916, 0.2875, 0.4385, 0.2923, 0.2816, 0.4396, 0.293}},
            {{0.4733, 0, 0, 0.4192, 0, 0, 0.3912, 0, 0, 0.3828, 0, 0},
{0.473, 0.06665, 0.04445, 0.4196, 0.06875, 0.04585, 0.39165, 0.0707, 0.0471, 0.3833, 0.07145, 0.04765},
{0.4727, 0.1333, 0.0889, 0.42, 0.1375, 0.0917, 0.3921, 0.1414, 0.0942, 0.3838, 0.1429, 0.0953},
{0.4716, 0.1993, 0.13285, 0.42125, 0.2048, 0.13655, 0.39395, 0.20995, 0.13995, 0.3855, 0.2121, 0.1414},
{0.4705, 0.2653, 0.1768, 0.4225, 0.2721, 0.1814, 0.3958, 0.2785, 0.1857, 0.3872, 0.2813, 0.1875},
{0.4705, 0.2653, 0.1768, 0.4272, 0.4012, 0.2675, 0.4039, 0.4071, 0.2714, 0.3954, 0.4103, 0.2735},
{0.4705, 0.2653, 0.1768, 0.4346, 0.5226, 0.3484, 0.4183, 0.5229, 0.3486, 0.4118, 0.5237, 0.3491}},
            {{0.6452, 0, 0, 0.575, 0, 0, 0.5425, 0, 0, 0.5335, 0, 0},
{0.6448, 0.0611, 0.0408, 0.5746, 0.06305, 0.042, 0.54205, 0.0647, 0.04315, 0.533, 0.0653, 0.04355},
{0.6435, 0.122, 0.0813, 0.5742, 0.1261, 0.084, 0.5416, 0.1294, 0.0863, 0.5325, 0.1306, 0.0871},
{0.6435, 0.122, 0.0813, 0.57305, 0.1874, 0.1249, 0.54035, 0.19215, 0.1281, 0.5313, 0.1939, 0.1293},
{0.6435, 0.122, 0.0813, 0.5719, 0.2487, 0.1658, 0.5391, 0.2549, 0.1699, 0.5301, 0.2572, 0.1715},
{0.6435, 0.122, 0.0813, 0.5689, 0.3648, 0.2432, 0.5381, 0.3723, 0.2482, 0.5281, 0.3756, 0.2504},
{0.6435, 0.122, 0.0813, 0.5689, 0.3648, 0.2432, 0.5398, 0.4773, 0.3182, 0.5304, 0.4803, 0.3202}}};

            if (Bk < 12.5) ii=0;            
            if (Bk >= 12.5 && Bk < 17.5) ii = 1;
            if (Bk >= 17.5 && Bk < 22.5) ii = 2;
            if (Bk >= 22.5 && Bk < 27.5) ii = 3;
            if (Bk >= 22.5) ii = 4; 


            if (Alpha < 1.25) jj = 0;
            if (Alpha >= 1.25 && Alpha < 3.75) jj = 1;
            if (Alpha >= 3.75 && Alpha < 6.25) jj = 2;
            if (Alpha >= 6.25 && Alpha < 8.75) jj = 3;
            if (Alpha >= 8.75 && Alpha < 12.5) jj = 4;
            if (Alpha >= 12.5 && Alpha < 17.5) jj = 5;
            if (Alpha >= 17.5) jj = 6;


            if (Mah < 2.5) kk = 0;
            if (Mah >= 2.5 && Mah < 4) kk = 3;
            if (Mah >= 4 && Mah < 6) kk = 6;
            if (Mah >= 6) kk = 9;


            CrHead = ArrKoef [ii, jj, kk];
            CnHead = ArrKoef[ii, jj, kk+1];
            mzHead = ArrKoef[ii, jj, kk+2];

            CxHead = CrHead * Math.Cos(Alpha) + CnHead * Math.Sin(Alpha);
            CyHead = CnHead * Math.Cos(Alpha) - CrHead * Math.Sin(Alpha);


            //Расчет коэффициента подъемной силы летательного аппарата в целом

            AA = Math.Pow(1 - (DiamMidel / FullWingspan), 2) / ((1 - Math.Pow(DiamMidel / FullWingspan, 3) + Math.Pow(DiamMidel / FullWingspan, 4)) * Math.Pow(TailWingspanFull / FullWingspan, 2));
            if (TailWingspanFull / FullWingspan < 1)
            {
                BB = 1;
            }
            else
            {
                BB = 1 - (((TailWingspanFull / FullWingspan) * (TailConstriction + 1) - TailConstriction + 1) * Math.Sqrt(Math.Pow(TailWingspanFull / FullWingspan, 2) - 1) / ((TailConstriction + 1) * EpsOp * EpsOp));
            }

            Etta = (WingConstriction + 1) / (2 * WingConstriction);
            lop = FullWingspan * (Etta * (1 - DiamMidel / FullWingspan) + (DiamMidel / FullWingspan));
            x_ = XX / (0.5 * TailWingspanFull);

            if (Mah < 1)
            {
                Kx = 0.5 * (1 + Math.Sqrt(1 + ((1 - Mah * Mah) / (x_ * x_))));
            }
            else
            {
                Kx = Math.Sqrt(1 - ((Mah * Mah - 1) / (x_ * x_)));
            }

            Kt = Math.Pow((1 + 0.415 * DiamMidel / FullWingspan), 2);
            Kkr = 1.17 * DiamMidel / FullWingspan * (1 - 0.71 * DiamMidel / FullWingspan);
            Kaa = Math.Pow(1 + DiamMidel / FullWingspan * (1.2 - 0.2 / WingConstriction), 2);

            CyAlphaHead=CyHead /(57.3*Math.Sin(Alpha)*Math.Cos(Alpha));
            CyaAlphaFuselage= CyAlphaHead - 0.035 * 0.2 * (1-Math.Pow(DiamMidel/TailDiam,2));

            CyAlphaFKr = CyaAlphaFuselage * MidelArea / WingArea + Kaa * CyAlpha * TailArea / WingArea;

            CyaFKr = CyAlphaFKr * Alpha;

            EpsAlpha = CyaFKr * Kx * AA * BB / (Math.PI * WingElongetion);

            KtTail = Math.Pow((1 + 0.415 * DiamMidel / TailWingspanFull), 2);
            KkrTail = 1.17 * DiamMidel / TailWingspanFull * (1 - 0.71 * DiamMidel / TailWingspanFull);

            CyAlpha = 0;

            CyFull = CyHead + (Kkr + Kt) * CyAlpha * Alpha * WingArea / MidelArea + 0.9 * (KkrTail + KtTail) * CyAlphaTail * (Alpha - EpsAlpha) * TailArea / MidelArea;

            //Расчет коэффициента момента летательного аппарата

            XcHead = 0.5 * 0.5 * DiamMidel / Math.Tan(Bk);
            mz = XcHead * CyHead / LengthLA + XcTail * 0.655 / LengthLA + XcWing * 0.580 / LengthLA;
                        //mz считается не правильно, надо разобраться и переделать
            Ccd = mz / CyFull;
            Xcd = Ccd * LengthLA;

            //Расчет коэффициента лобового сопротивления летательного аппарата

            //расчет коэффициента лобового сопротивления корпуса

                        //будет считаться для головной части в виде заостренного конуса

            Cxv = CxHead;
            Cxi = 2 * (TailArea / MidelArea) * Alpha * Alpha;
            if (Laminar.Checked == true) { Ckoef = 1.2; }
            if (Turbo.Checked == true) { Ckoef = 0.35; }
            CylinderElongation = CylinderLength / DiamMidel;
            EndElongation = TailLength / DiamMidel;
            Cxotr = Ckoef * (4 / Math.PI) * (CylinderElongation + EndElongation) * Math.Pow(Alpha, 3);

            K1 = Mah / ((LengthLA / DiamMidel) / (TailArea / MidelArea));
            if (K1 >1 )
            {
                Cxd = (1.43 / Math.Pow(Mah, 2)) * (TailArea / MidelArea);
            }
            else
            {
                Cxd = 1.144 * K1 * (2 - K1) * (1 / Math.Pow(Mah, 2)) * (TailArea / MidelArea);
            }

            Cxx = ((0.000496 / Math.Pow(1 + 0.03 * Mah * Mah, 1 / 3)) * 0.8 + (0.0396 / Math.Pow(1 + 0.12 * Mah * Mah, 1 / 2)) * ((1 / Math.Pow(6500000, 0.143)) - 0.1 * 0.8)) * 0.8;
                        //вместо 0.8 должно быть Sл/Sб (Sл - поверхность занятая ламинарным течением, Sб - боковая поверхность корпуса)

            CxKor = Cxv + Cxi + Cxotr + Cxx + Cxd;


            //Расчет коэффициента волнового сопротивления несущих поверхностей

            K2Tail=4;
            K2Wing=4;
            Xc_Tail=0.5;
            Xc_Wing=0.5;

            Cxv0Wing = (K2Wing * Math.Pow(C_Wing, 2)) / Math.Sqrt(Math.Pow(Mah, 2)-1);
            Cxv0Tail = (K2Tail * Math.Pow(C_Tail, 2)) / Math.Sqrt(Math.Pow(MahTail, 2)-1);

            CxiCxvWing = ((4 * Alpha * Alpha) / Math.Sqrt(Math.Pow(Mah, 2)-1)) * (1 - (1 / (2 * WingElongetion * Math.Sqrt(Math.Pow(Mah, 2)-1))));
            CxiCxvTail = ((4 * Alpha * Alpha) / Math.Sqrt(Math.Pow(MahTail, 2)-1)) * (1 - (1 / (2 * TailElongation * Math.Sqrt(Math.Pow(MahTail, 2)-1))));

            ReWing = SpeedInf * WingArea / (NuInf * Wingspan);
            ReTail = SpeedInf * TailArea /(NuInf * (TailWingspanFull-DiamMidel));

            CxxWing = 0.0315 * Math.Pow(ReWing, (0 - 0.145));
            CxxTail = 0.0315 * Math.Pow(ReTail, (0 - 0.145));

            CxWing = (2 * Cxv0Wing + 4 * CxxWing + CxiCxvWing) * WingArea / MidelArea;
            CxTail = (2 * Cxv0Tail + 4 * CxxTail + CxiCxvTail) * TailArea / MidelArea;

            CxWing = 0;

            Cx = CxKor + CxWing * WingArea / MidelArea + 0.9 * CxTail * TailArea / MidelArea;

            TxtResultCx.Text = Convert.ToString(Cx);
            TxtResultCy.Text = Convert.ToString(Cy);
            TxtResultMz.Text = Convert.ToString(mz);




        }


 
    }

    
}
