# Progress Log

## Session: 2026-05-30

### 基于真实调研重写计划
- **Status:** complete
- Actions taken:
  - 读取两份调研文档（成都/深圳JD + C#上位机学习指南）
  - 对比原计划，发现8处缺口
  - 重写task_plan.md：加入Dapper/EF Core、S7.Net、CommunityToolkit.Mvvm、Git、报警/权限/日志/Excel
  - 新增阶段零（环境与工具链）
  - 阶段从WinForm单一框架改为WinForm+WPF并行
- Files created/modified:
  - .planning/task_plan.md（全新，基于真实数据）
  - .planning/findings.md（全新，含调研结论+缺口分析）
  - .planning/progress.md（本文件）
  - 旧文件已全部删除

### 阶段零·D4-5：WinForm动态控件复习
- **Status:** complete
- Actions taken:
  - Button/TextBox/ListBox/ComboBox/Label/Panel/GroupBox 动态创建
  - 事件绑定 + sender转型 + 控件交互

---

## Error Log

| Timestamp | Error | Attempt | Resolution |
|-----------|-------|---------|------------|
| 5/29 | ListBox代替Label | 1 | 改声明 |
| 5/29 | SelectedIndex代替事件 | 1 | 改事件名 |
| 5/30 | Panel/GroupBox未Add | 1 | 加this.Controls.Add |
| 5/30 | GroupBox尺寸太小 | 2 | 调整宽高 |

## 5-Question Reboot Check

| Question | Answer |
|----------|--------|
| Where am I? | 阶段零·D1：Git安装 + 环境配置 |
| Where am I going? | D2 VS2022双环境 → D3 NuGet → D6-7周末项目 |
| What's the goal? | 2027年3月入职成都上位机 |
| What have I learned? | 调研数据：Dapper/EF Core/S7.Net是原计划缺的 |
| What have I done? | 基于真实JD调研重写了全部计划 |
