## 项目背景

C#上位机学习项目，用户0基础 + 自动化售后调试背景，目标2027年3月入职成都。

## 数据来源

计划基于2025-2026年成都/深圳公开JD调研 + 四家AI（ChatGPT/Gemini/豆包）交叉验证。

## 路线

详见 `.planning/task_plan.md`，五阶段：
0. 环境与工具链（1周）✅ 已完成
1. C#进阶+多线程+文件IO（4周）
2. SQL Server+Dapper+EF Core（5周）
3. 工业通信（TCP/SerialPort/Modbus/S7/OPC UA）（8周）
4. WPF+MVVM+项目实战（8周）

## 技术栈

C#、WinForm、WPF、MVVM(CommunityToolkit)、SQL Server、MySQL(概念)、Dapper、EF Core、Socket、TCP/UDP、SerialPort、Modbus TCP/RTU、S7.Net、OPC UA(概念)、LiveCharts、HandyControl、Git、EPPlus/ClosedXML、NLog、SunnyUI、Wireshark

## 红线

- 禁止 CheckForIllegalCrossThreadCalls = false
- 禁止简历写SQLite
- 禁止拖控件
- 禁止WPF深挖ControlTemplate/动画/毛玻璃
- 禁止WinForm原生控件自定义样式——用SunnyUI
- 计划基于真实数据，禁止臆测

## GitHub 推送

当用户说"推送到GitHub"、"push"、"上传到GitHub"、"同步到GitHub"时：
- 先 git add -A + git commit
- 然后提醒用户双击 `push.bat` 或在 PowerShell 执行 `cd E:\VS\WindowsFormsApp1; git push`
- Shell环境无法直连GitHub，推送需用户手动执行

## 学习节奏规则

### 自动推进
- 按天规划，每天一个明确知识点/任务
- 完成当天任务后自动引导到下一天

### 不自动跳过
- 当天知识点没学完 → 不跳到下一天
- 小阶段结束主动询问掌握情况
- 用户说"还没好" → 不推进

### 练习机制
- 每天有小练手（10-15分钟）
- 每周有综合项目
- 项目来源：GitHub搜索优先 → 找不到自创

### 遇到问题
1. 独立思考改代码
2. GitHub搜索
3. Microsoft官方文档
4. 再问我

## 规划文件

| 文件 | 用途 |
|------|------|
| .planning/task_plan.md | 五阶段+JD匹配+四家AI决策记录 |
| .planning/findings.md | 调研结论+AI交叉验证矩阵 |
| .planning/progress.md | 会话日志+错误记录+五问检查 |

## 当前进度

阶段一·W1D1：委托 delegate（下次开课）

- [x] 阶段零全部完成 ✅
- [x] TODO列表周末项目 push到GitHub ✅
- [ ] 下次：委托 delegate、Action、Func
