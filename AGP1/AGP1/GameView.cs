using Android.Views;
using Android.Graphics;
using Android.Content;

namespace AGP1
{
    public class GameView : View
    {
        Bitmap bmp;

        public GameView(Context context)
            : base(context)
        {
            bmp = BitmapFactory.DecodeResource(Resources, Resource.Drawable.Icon);
        }

        protected override void OnDraw(Canvas canvas)
        {
            canvas.DrawColor(Color.Argb(255, 69, 119, 102));
            canvas.DrawBitmap(bmp, 50, 100, null);
        }
    }
}

