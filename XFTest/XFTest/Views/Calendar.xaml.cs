using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendar : ContentView
    {
        public int dayID;

        public Calendar()
        {
            InitializeComponent();

            //current day select
            DateTime dt = DateTime.Now;
            dayID = dt.Day;
            switch (dayID)
            {
                case 1:
                    {
                        One.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mOne);
                    }
                    break;
                case 2:
                    {
                        Two.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwo);
                    }
                    break;
                case 3:
                    {
                        Three.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mThree);
                    }
                    break;
                case 4:
                    {
                        Four.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mFour);
                    }
                    break;
                case 5:
                    {
                        Five.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mFive);
                    }
                    break;
                case 6:
                    {
                        Six.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mSix);
                    }
                    break;
                case 7:
                    {
                        Seven.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mSeven);
                    }
                    break;
                case 8:
                    {
                        Eight.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mEight);
                    }
                    break;
                case 9:
                    {
                        Nine.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mNine);
                    }
                    break;
                case 10:
                    {
                        Ten.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTen);
                    }
                    break;
                case 11:
                    {
                        Eleven.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mEleven);
                    }
                    break;
                case 12:
                    {
                        Twelve.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwelve);
                    }
                    break;
                case 13:
                    {
                        Thirteen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mThirteen);
                    }
                    break;
                case 14:
                    {
                        Fourteen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mFourteen);
                    }
                    break;
                case 15:
                    {
                        Fifteen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mFifteen);
                    }
                    break;
                case 16:
                    {
                        Sixteen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mSixteen);
                    }
                    break;
                case 17:
                    {
                        Seventeen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mSeventeen);
                    }
                    break;
                case 18:
                    {
                        Eighteen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mEighteen);
                    }
                    break;
                case 19:
                    {
                        Nineteen.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mNineteen);
                    }
                    break;
                case 20:
                    {
                        Twenty.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwenty);
                    }
                    break;
                case 21:
                    {
                        TwentyOne.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyOne);
                    }
                    break;
                case 22:
                    {
                        TwentyTwo.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyTwo);
                    }
                    break;
                case 23:
                    {
                        TwentyThree.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyThree);
                    }
                    break;
                case 24:
                    {
                        TwentyFour.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyFour);
                    }
                    break;
                case 25:
                    {
                        TwentyFive.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyFive);
                    }
                    break;
                case 26:
                    {
                        TwentySix.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentySix);
                    }
                    break;
                case 27:
                    {
                        TwentySeven.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentySeven);
                    }
                    break;
                case 28:
                    {
                        TwentyEight.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyEight);
                    }
                    break;
                case 29:
                    {
                        TwentyNine.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mTwentyNine);
                    }
                    break;
                case 30:
                    {
                        Thirty.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mThirty);
                    }
                    break;
                case 31:
                    {
                        ThirtyOne.BackgroundColor = Color.FromHex("#368268");
                        StarAnimate(mThirtyOne);
                    }
                    break;

            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            var state = width < 280 ? "Small" : width == 320 ? "Small" : width < 380 ? "Medium" : "Large";
            VisualStateManager.GoToState(dayLbl01, state);
            VisualStateManager.GoToState(dayLbl02, state);
            VisualStateManager.GoToState(dayLbl03, state);
            VisualStateManager.GoToState(dayLbl04, state);
            VisualStateManager.GoToState(dayLbl05, state);
            VisualStateManager.GoToState(dayLbl06, state);
            VisualStateManager.GoToState(dayLbl07, state);
            VisualStateManager.GoToState(dayLbl08, state);
            VisualStateManager.GoToState(dayLbl09, state);
            VisualStateManager.GoToState(dayLbl10, state);
            VisualStateManager.GoToState(dayLbl11, state);
            VisualStateManager.GoToState(dayLbl12, state);
            VisualStateManager.GoToState(dayLbl13, state);
            VisualStateManager.GoToState(dayLbl14, state);
            VisualStateManager.GoToState(dayLbl15, state);
            VisualStateManager.GoToState(dayLbl16, state);
            VisualStateManager.GoToState(dayLbl17, state);
            VisualStateManager.GoToState(dayLbl18, state);
            VisualStateManager.GoToState(dayLbl19, state);
            VisualStateManager.GoToState(dayLbl20, state);
            VisualStateManager.GoToState(dayLbl21, state);
            VisualStateManager.GoToState(dayLbl22, state);
            VisualStateManager.GoToState(dayLbl23, state);
            VisualStateManager.GoToState(dayLbl24, state);
            VisualStateManager.GoToState(dayLbl25, state);
            VisualStateManager.GoToState(dayLbl26, state);
            VisualStateManager.GoToState(dayLbl27, state);
            VisualStateManager.GoToState(dayLbl28, state);
            VisualStateManager.GoToState(dayLbl29, state);
            VisualStateManager.GoToState(dayLbl30, state);
            VisualStateManager.GoToState(dayLbl31, state);

           

            VisualStateManager.GoToState(calPad01, state);
            VisualStateManager.GoToState(calPad02, state);
            VisualStateManager.GoToState(calPad03, state);
            VisualStateManager.GoToState(calPad04, state);
            VisualStateManager.GoToState(calPad05, state);
            VisualStateManager.GoToState(calPad06, state);
            VisualStateManager.GoToState(calPad07, state);
            VisualStateManager.GoToState(calPad08, state);
            VisualStateManager.GoToState(calPad09, state);
            VisualStateManager.GoToState(calPad10, state);
            VisualStateManager.GoToState(calPad11, state);
            VisualStateManager.GoToState(calPad12, state);
            VisualStateManager.GoToState(calPad13, state);
            VisualStateManager.GoToState(calPad14, state);
            VisualStateManager.GoToState(calPad15, state);
            VisualStateManager.GoToState(calPad16, state);
            VisualStateManager.GoToState(calPad17, state);
            VisualStateManager.GoToState(calPad18, state);
            VisualStateManager.GoToState(calPad19, state);
            VisualStateManager.GoToState(calPad20, state);
            VisualStateManager.GoToState(calPad21, state);
            VisualStateManager.GoToState(calPad22, state);
            VisualStateManager.GoToState(calPad23, state);
            VisualStateManager.GoToState(calPad24, state);
            VisualStateManager.GoToState(calPad25, state);
            VisualStateManager.GoToState(calPad26, state);
            VisualStateManager.GoToState(calPad27, state);
            VisualStateManager.GoToState(calPad28, state);
            VisualStateManager.GoToState(calPad29, state);
            VisualStateManager.GoToState(calPad30, state);
            VisualStateManager.GoToState(calPad31, state);

            

        }
        //01
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.FromHex("#368268");
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //02
        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.FromHex("#368268");
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //03
        void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.FromHex("#368268");
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //04
        void TapGestureRecognizer_Tapped_3(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.FromHex("#368268");
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //05
        void TapGestureRecognizer_Tapped_4(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.FromHex("#368268");
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //06
        void TapGestureRecognizer_Tapped_5(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.FromHex("#368268");
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //07
        void TapGestureRecognizer_Tapped_6(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.FromHex("#368268");
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //08
        void TapGestureRecognizer_Tapped_7(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.FromHex("#368268");
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //09
        void TapGestureRecognizer_Tapped_8(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.FromHex("#368268");
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //10
        void TapGestureRecognizer_Tapped_9(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.FromHex("#368268");
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //11
        void TapGestureRecognizer_Tapped_10(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.FromHex("#368268");
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //12
        void TapGestureRecognizer_Tapped_11(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.FromHex("#368268");
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //13
        void TapGestureRecognizer_Tapped_12(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.FromHex("#368268");
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //14
        void TapGestureRecognizer_Tapped_13(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.FromHex("#368268");
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //15
        void TapGestureRecognizer_Tapped_14(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.FromHex("#368268");
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //16
        void TapGestureRecognizer_Tapped_15(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.FromHex("#368268");
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //17
        void TapGestureRecognizer_Tapped_16(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.FromHex("#368268");
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //18
        void TapGestureRecognizer_Tapped_17(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.FromHex("#368268");
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //19
        void TapGestureRecognizer_Tapped_18(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.FromHex("#368268");
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //20
        void TapGestureRecognizer_Tapped_19(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.FromHex("#368268");
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //21
        void TapGestureRecognizer_Tapped_20(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.FromHex("#368268");
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //22
        void TapGestureRecognizer_Tapped_21(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.FromHex("#368268");
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //23
        void TapGestureRecognizer_Tapped_22(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.FromHex("#368268");
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //24
        void TapGestureRecognizer_Tapped_23(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.FromHex("#368268");
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //25
        void TapGestureRecognizer_Tapped_24(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.FromHex("#368268");
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //26
        void TapGestureRecognizer_Tapped_25(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.FromHex("#368268");
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //27
        void TapGestureRecognizer_Tapped_26(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.FromHex("#368268");
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //28
        void TapGestureRecognizer_Tapped_27(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.FromHex("#368268");
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //29
        void TapGestureRecognizer_Tapped_28(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.FromHex("#368268");
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //30
        void TapGestureRecognizer_Tapped_29(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.FromHex("#368268");
            ThirtyOne.BackgroundColor = Color.Transparent;
        }
        //31
        void TapGestureRecognizer_Tapped_30(System.Object sender, System.EventArgs e)
        {
            One.BackgroundColor = Color.Transparent;
            Two.BackgroundColor = Color.Transparent;
            Three.BackgroundColor = Color.Transparent;
            Four.BackgroundColor = Color.Transparent;
            Five.BackgroundColor = Color.Transparent;
            Six.BackgroundColor = Color.Transparent;
            Seven.BackgroundColor = Color.Transparent;
            Eight.BackgroundColor = Color.Transparent;
            Nine.BackgroundColor = Color.Transparent;
            Ten.BackgroundColor = Color.Transparent;
            Eleven.BackgroundColor = Color.Transparent;
            Twelve.BackgroundColor = Color.Transparent;
            Thirteen.BackgroundColor = Color.Transparent;
            Fourteen.BackgroundColor = Color.Transparent;
            Fifteen.BackgroundColor = Color.Transparent;
            Sixteen.BackgroundColor = Color.Transparent;
            Seventeen.BackgroundColor = Color.Transparent;
            Eighteen.BackgroundColor = Color.Transparent;
            Nineteen.BackgroundColor = Color.Transparent;
            Twenty.BackgroundColor = Color.Transparent;
            TwentyOne.BackgroundColor = Color.Transparent;
            TwentyTwo.BackgroundColor = Color.Transparent;
            TwentyThree.BackgroundColor = Color.Transparent;
            TwentyFour.BackgroundColor = Color.Transparent;
            TwentyFive.BackgroundColor = Color.Transparent;
            TwentySix.BackgroundColor = Color.Transparent;
            TwentySeven.BackgroundColor = Color.Transparent;
            TwentyEight.BackgroundColor = Color.Transparent;
            TwentyNine.BackgroundColor = Color.Transparent;
            Thirty.BackgroundColor = Color.Transparent;
            ThirtyOne.BackgroundColor = Color.FromHex("#368268");
        }

        //show current day
        private void StarAnimate(Element v)
        {
            Device.StartTimer(TimeSpan.FromSeconds(4), () =>
            {

                ScrollViewLayout.ScrollToAsync(v, ScrollToPosition.Center, true);
                return false;
            });
        }
        
    }
}