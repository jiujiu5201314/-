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