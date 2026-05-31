# Progress Log

## Session: 2026-05-31

### 阶段一·W1D1-D4：委托 → 事件 → Lambda → LINQ ✅
- **Status:** complete
- Actions taken:
  - delegate：手写 MyEventHandler 模具 + Publisher 事件类
  - 事件：pub.OnSomething += MsgHandler → 理解 Click 底层原理
  - Lambda：(msg) => { ... } 替换四行方法
  - LINQ：Where/Select/OrderBy/GroupBy 四件套
  - 消除了 EventDemo.cs 和 Form1.cs 的事件+Lambda+LINQ代码
- Files modified: Form1.cs, EventDemo.cs (新增)

### 阶段一·W1D5：LINQ 实战（当前）
- 模拟设备数据 + Where筛选 + OrderByDescending倒排 + Select取字段

---

## Error Log

| Timestamp | Error | Attempt | Resolution |
|-----------|-------|---------|------------|
| 5/31 | GroupBy(n => n > 10) 理解错误 | 1 | 改为按奇偶分组 |
| 5/31 | Lambda 字母打错 | 1 | 修正变量名 |

## 5-Question Reboot Check

| Question | Answer |
|----------|--------|
| Where am I? | 阶段一·W1D5：LINQ实战练手 |
| Where am I going? | W1D6-7 周末项目 → W2 文件IO |
| What's the goal? | 2027年3月入职成都上位机 |
| What have I learned? | delegate→event→Lambda→LINQ 完成链路 |
| What have I done? | W1D1-D4 全部完成 |
