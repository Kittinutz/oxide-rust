# Config

ก๊อบของ ที่อยู่ใน `plugins` กับ `config` ไปวาง

```
 public class ConfigFile
        {
            [JsonProperty("Add booster if already has one?")]
            public bool AddOldBooster = true;

            [JsonProperty("Default Max Health")] public float MaxHealth = 150f;

            [JsonProperty("Max Health Permissions")]
            public Dictionary<string, float> Permissions = new Dictionary<string, float>
            {
                {"vip", 300f},
                {"police", 500f}
                //เพิ่ม permission กับ เลือดไว้ตรงนี้
                //BetterHealth: 150
                // อย่าลืมเพิ่มใน BetterHealth.json ด้วย
            };
        }
```