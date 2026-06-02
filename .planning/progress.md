# Progress Log

## Session: 2026-05-31

### 阶段零 ✅ 完成
- Git + GitHub + NuGet + WinForm复习 + TODO项目

### 阶段一·W1D1-D5 ✅ 完成
- delegate/event/Lambda/LINQ 四件套 + 链式调用

### 阶段一·W1D6-7：周末项目 ✅
- 任务：ComboBox筛选 + ListBox显示
- 数据：6台PLC提到类级别
- 三个选项：全部/高温(>40)/低温(≤40)
- LINQ Where 实时筛选

---

## Error Log

| Timestamp | Error | Attempt | Resolution |
|-----------|-------|---------|------------|
| 5/31 | GroupBy(n => n > 10) | 1 | 改为奇偶分组 |
| 5/31 | Lambda `< >` 语法错 | 1 | 去尖括号 |
| 5/31 | 链式调用户号截断 | 1 | 只最后加; |
| 5/31 | r1无弹窗 | 1 | 加MessageBox |

## 5-Question Reboot Check

| Question | Answer |
|----------|--------|
| Where am I? | W1D6-7：周末项目——数据筛选工具 |
| Where am I going? | W2 文件IO |
| What's the goal? | 2027年3月入职成都上位机 |
| What have I learned? | delegate→event→Lambda→LINQ |
| What have I done? | 阶段零+W1D1-D5完成 |

---

## Session: 2026-05-31（续）

### 阶段一·W1D6-7 ✅ 完成 — 周末项目：数据筛选小工具

- 补全 CmbFilter_Changed 三个分支（全部/高温/低温）
- Form1.cs 中文乱码修复（19处，PowerShell UTF8重写）
- cmbFilter 事件绑定修正（Cmb_Changed → CmbFilter_Changed）
- 删除不存在的 config 变量引用
- lbxResult 位置修正

### AGENTS.md 新增规则
- 代码自检规则：生成代码后必须 build 验证 + 中文检查 + 逻辑检查
- 发现问题立即修，不等用户报错

## Error Log

| Timestamp | Error | Attempt | Resolution |
|-----------|-------|---------|------------|
| 5/31 | Form1.cs 全文中文字符串乱码（U+FFFD） | 1 | PowerShell UTF8-BOM here-string重写 |
| 5/31 | dotnet build MSBuild权限不足 | 1 | 环境问题，非代码问题，VS内F5正常 |

## 5-Question Reboot Check

| Question | Answer |
|----------|--------|
| Where am I? | 阶段一·W2D1：文件IO |
| Where am I going? | W2 文件读写→W3 多线程 |
| What's the goal? | 2027年3月入职成都上位机 |
| What have I learned? | delegate→event→Lambda→LINQ→数据筛选项目 |
| What have I done? | 阶段零+阶段一W1全部完成 |
---

## Session: 2026-06-02

### 阶段一·W2D1 ✅ 完成 — 文件读写

- File.WriteAllText / File.ReadAllText
- Split + StringSplitOptions.RemoveEmptyEntries
- VS旧版本缓存导致"加载"不触发 → 重新生成解决

### Error Log

| Timestamp | Error | Attempt | Resolution |
|-----------|-------|---------|------------|
| 6/2 | btnSave无Location/Size，按钮0×0不可见 | 2 | 补Location+Size |
| 6/2 | 加载按钮无反应 | 3 | VS未重新编译，重新生成解决 |
---

## Session: 2026-06-02（续）

### 阶段一·W2D2 ✅ 完成 — StreamReader/StreamWriter

- btnSave：StreamWriter + WriteLine 逐行写入
- btnLoad：StreamReader + ReadLine + while 逐行读取
- using 自动关闭资源
- 路径统一为 `E:\data.txt`
---

## Session: 2026-06-02（续2）

### 阶段一·W2D3 ✅ 完成 — JSON序列化

- `JsonConvert.SerializeObject(对象)` — 装箱：C#对象→JSON字符串
- `JsonConvert.DeserializeObject<dynamic>(字符串)` — 拆箱：JSON字符串→C#对象
- `dynamic` 关键字理解
- JSON版保存/加载按钮（data.json）
- lbx位置调整解决按钮重叠
---

## Session: 2026-06-02（续3）

### 阶段一·W2D4 ✅ 完成 — XML读写

- XmlDocument/CreateElement/AppendChild/InnerText/Save（写入）
- Load/GetElementsByTagName/InnerText（读取）
- XML格式：`<items><item>数据</item></items>`
- 修复btnLoadJson.Click错误绑定
---

## Session: 2026-06-02（续4）

### 阶段一·W2D5 ✅ 完成 — 配置面板保存/加载JSON

- AppConfig 自定义数据类（袋子装状态）
- FormClosing 事件（窗口关闭前自动保存）
- File.Exists 保护（首次运行跳过加载）
- 保存：FormClosing → 取值 → Serialize → WriteAllText
- 加载：构造函数末尾 → File.Exists → ReadAllText → Deserialize → 还原控件
- 排坑：tbx.Clear() 导致存空字符串，非代码bug，操作顺序问题## Session: 2026-06-02（续5）

### ⭐ 多线程阶段规划重写

- 多线程标记为阶段一核心重点，弹性拉长至5~6周
- 每个知识点标注JD对应关系 + 面试题自测
- 新增：死锁实战日、ConcurrentQueue工业采集模式
- findings.md 新增多线程JD专项调研（面试真题还原）
- task_plan.md W3-W4 全面重写
- 决策记录新增3条（弹性节奏/面试自测/死锁实战）

### Git同步
- 关联远程仓库 https://github.com/jiujiu5201314/-.git
- 合并App1/App2历史 → push成功
- push.bat 增加远程检查+友好提示

### 项目清理
- Form1.cs 清空为骨架
- ConfigForm.cs 重建为W2周末项目
- Program.cs 入口改为ConfigForm

## Session: 2026-06-03

### ⭐ 规划修正案（三家AI交叉验证 + 用户裁决）

- Gemini / 豆包 / ChatGPT 三家评价交叉分析
- 6 条修正中采纳 5 条（第 6 条"买PLC真机"用户否决）
- task_plan.md 全面重写：SQLite 解禁、多线程挂通信、Modbus 手撕报文、WPF 精简、项目 3 模块闭环
- findings.md 新增修正案记录 + 被否决项记录
- EF Core 降为半天概念了解，Dapper 为主

## Session: 2026-06-03（续）

### 🪓 计划大砍——从"全家桶"到"能干活"

- 三家 AI 交叉评价后，自行判断初级岗真实需求
- 砍掉：EF Core、OPC UA、Prism、WPF样式动画、SynchronizationContext、ConcurrentQueue、MySQL深钻、多协议架构
- 保留 4 件事：多线程(1周) → 数据库(2周) → 通信(3周) → WPF+项目(2周)
- 总共 8 周，不拉长
- 简历项目只做一个：PLC数据采集监控
- 面试题从 7 类 20+ 题砍到 6 题，只要能手写核心代码

## Session: 2026-06-03（续2）

### 📐 10个月时间线重排

- 内容不变（砍过的），时间拉开到10个月
- 多线程 3周 → 数据库 5周 → 通信 12周 → WPF 8周 → 项目+面试 10周
- 总共 40 周，预留缓冲
- 每个周末标注了具体练习项目
- 通信阶段给了最长时间（12周），因为这是最值钱的部分

## Session: 2026-06-03（终版）

### 🎯 终版计划：四家AI交叉验证 + 自主判断

- 路线逻辑：C#基本功→数据库→多线程→通信→WPF→项目+求职
- 核心判断：
  - 多线程不放第1个月：0基础先有UI和DB，多线程才有东西可跑
  - WPF放最后：等你采回数据、存进库，WPF才有东西可绑
  - 通信是最长阶段（10周）：这是你最值钱的部分
- 采纳 Gemini：手撕Modbus报文、Wireshark跟通信走
- 采纳 豆包：3模块闭环、面试话术、投简历策略
- 采纳 ChatGPT v4："先能写程序→再连设备→最后美化界面"的顺序
- 采纳 ChatGPT v3：简历模板、投简历策略、售后优势话术
- 保留自己的判断：多线程放第5个月（非第1个月也非第8个月）
