package nan.nl.testjson;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.Reader;
import java.io.StringWriter;
import java.io.Writer;
import java.nio.charset.StandardCharsets;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {

            private Map ChampIdPair = FastArray();

            @Override
            public void onClick(View view) {

                action(view);
            }

            public void action(View view) {

                String text = JsonParse(R.raw.champion_mastery_v4_blaxadowfire);
                String test = "";
                TextView textView = (TextView) findViewById(R.id.labeltext);
                Integer i = 69; //CHAMPION NUMBER
//                String test = JsonObjectString(JsonArrayString(text, 0), "summonerId");
                try{
                    JSONArray jsonArray = new JSONArray(text);
                    for (Integer j = 0; j < 999; j++){
//                        test += JsonArrayGetChampName(JsonArrayGetChampId(text,j));
                        if (ChampIdPair.get(j) != null){
                            test += "\r\n";
                        }
                    }

                }
                catch (JSONException e){
                    e.printStackTrace();
                }


                textView.setText(test);
            }


        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    public String JsonParse(int JsonFile) {
        String jsonString = null;
        try {
            InputStream is = getResources().openRawResource(JsonFile);
            Writer writer = new StringWriter();
            char[] buffer = new char[1024];
            try {
                Reader reader = new BufferedReader(new InputStreamReader(is, StandardCharsets.UTF_8));
                int n;
                while ((n = reader.read(buffer)) != -1) {
                    writer.write(buffer, 0, n);
                }
            } finally {
                is.close();
            }

            jsonString = writer.toString();

        }
        catch(IOException e)
        {
            e.printStackTrace();
        }
        return jsonString;
    }

    public String JsonObjectString(String jsonString, String key){
        try {
    JSONObject jsonObject = new JSONObject(jsonString);
    String test = jsonObject.getString(key);
    return test;
        }
        catch (JSONException e){
            e.printStackTrace();
        }
        return null;
    }

    public String JsonArrayString(String jsonString, Integer i){
        try {
            JSONArray jsonArray = new JSONArray(jsonString);
            String test = jsonArray.getString(i);
            return test;
        }
        catch (JSONException e){
            e.printStackTrace();
        }
        return null;
    }

    public Integer JsonArrayGetChampId(String s, Integer i){
        String championId = JsonObjectString(JsonArrayString(s,i),"championId");
        return Integer.parseInt(championId);
    }

    public String JsonArrayGetChampName(Integer i){
        String jsonString = JsonParse(R.raw.champion);

        jsonString = JsonObjectString(jsonString, "data");
        try {
            String champ = null;
            JSONObject jsonObject = new JSONObject(jsonString);
            Iterator keys = jsonObject.keys();
            while (keys.hasNext()){
                champ = jsonObject.getString((String)keys.next());

                if(Integer.parseInt(JsonObjectString(champ, "key")) == i){
                    return JsonObjectString(champ, "name");
                }

            }
            return null;
        }
        catch (JSONException e){
            e.printStackTrace();
        }
        return null;
    }

    public Map FastArray(){
        Map<Integer, String> map = new HashMap<Integer, String>();
        String jsonString = JsonParse(R.raw.champion);

        jsonString = JsonObjectString(jsonString, "data");
        try {
            String champ = "";
            JSONObject jsonObject = new JSONObject(jsonString);
            Iterator keys = jsonObject.keys();
            while (keys.hasNext()){
                champ = jsonObject.getString((String)keys.next());
                map.put(Integer.parseInt(JsonObjectString(champ, "key")),JsonObjectString(champ, "name"));

            }
            return map;
        }
        catch (JSONException e){
            e.printStackTrace();
        }
        return null;
    }
}
