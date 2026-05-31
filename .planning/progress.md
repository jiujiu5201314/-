# Progress Log

## Session: 2026-05-31

### 阶段一·W1D1-D5：委托 → 事件 → Lambda → LINQ 全部完成 ✅
- **Status:** complete
- Actions taken:
  - delegate：手写 MyEventHandler 模具 + Publisher 事件类
  - event：pub.OnSomething += MsgHandler → 理解 Click 底层
  - Lambda：(msg) => { ... } 压缩四行方法成一行
  - LINQ 四件套：Where/Select/OrderBy/GroupBy
  - 链式调用：devices.Where.OrderByDescending.Select
- Files: Form1.cs, EventDemo.cs

### 阶段一·W1D6-7：周末项目（当前）
- **Status:** in_progress
- 任务：ComboBox 筛选 + ListBox 显示设备列表
  - 数据源：6台PLC提到类级别
  - 三个选项：全部/高温/低温
  - SelectedIndexChanged → LINQ筛选 → 更新ListBox

---

## Error Log

| Timestamp | Error | Attempt | Resolution |
|-----------|-------|---------|------------|
| 5/31 | GroupBy(n => n > 10) 逻辑错 | 1 | 改为奇偶分组 |
| 5/31 | Lambda `< >` 混淆 | 1 | 去掉尖括号 |
| 5/31 | 链式调用加分号截断 | 1 | 只最后一行加分号 |
| 5/31 | r1无弹窗看不到结果 | 1 | 加MessageBox显示 |

## 5-Question Reboot Check

| Question | Answer |
|----------|--------|
| Where am I? | 阶段一·W1D6-7：周末项目——数据筛选工具 |
| Where am I going? | W2文件IO |
| What's the goal? | 2027年3月入职成都上位机 |
| What have I learned? | delegate→event→Lambda→LINQ完整链路 |
| What have I done? | W1D1-D5全部完成 |
