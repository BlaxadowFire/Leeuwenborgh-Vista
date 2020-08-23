package nl.nan_it.myapplication.feature;

import android.media.Image;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ImageView imageView = (ImageView) findViewById(R.id.imageView);

        int imageResource = getResources().getIdentifier("@drawable/r4", null, this.getPackageName());
        imageView.setImageResource(imageResource);
    }
}
