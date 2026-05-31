# 上位机开发学习计划（基于成都/深圳真实JD调研 + 四家AI共识提取）

> 数据来源：2025-2026年猎聘/智联/BOSS直聘/前程无忧公开岗位调研报告 + ChatGPT/Gemini/豆包交叉验证
> 目标：2027年3月入职成都上位机开发
> 用户背景：0基础编程 + 自动化售后调试经验
> 节奏：每晚2-2.5h，5+2模式

---

## 调研核心发现

| 发现 | 来源 | 影响 |
|------|------|------|
| C# + WPF + MVVM 是成都/深圳上位机标配 | 调研报告 | 阶段四重心 |
| WinForm + WPF **两者都要会** | 调研报告+四家AI共识 | 不能放弃WinForm |
| SQL Server + MySQL 都要了解 | 学习指南+JD | 阶段二补MySQL概念 |
| Dapper/EF Core 至少会一个 | 学习指南 | 阶段二加入 |
| 西门子S7 是PLC通信首选 | 学习指南+ChatGPT共识 | 阶段三加实操 |
| 推荐项目含报警/权限/日志/Excel | 学习指南+四家AI共识 | 穿线项目加这些模块 |
| Git/SVN 版本控制必备 | 调研报告+豆包v2 | 全程使用 |
| 通信 > 界面，WPF 是碗不是饭 | ChatGPT+Gemini共识 | WPF只学到够用 |
| 工业控件库（SunnyUI）优于原生 | 豆包v2 | 阶段一引入 |

---

## 阶段零：环境与工具链（1周）
### 状态：in_progress

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| 1 | Git安装 + GitHub账号 + 项目初始化 | ✅ |
| 2 | VS2022配置（.NET Framework 4.7.2 + .NET 8双环境） | ✅ |
| 3 | NuGet基础使用 | ✅ |
| 4-5 | WinForm动态控件复习（Button/TextBox/ListBox/ComboBox/Label/Panel/GroupBox） | ✅ |
| 6-7 | 周末：TODO列表小工具 push到GitHub | 🔄 |

---

## 阶段一：C# 进阶 + 多线程 + 文件IO（4周）
### 状态：in_progress

> 覆盖：委托/事件、Lambda、LINQ、Task/async-await、JSON/XML
> 工具：SunnyUI（工业控件库，替代原生WinForm样式）

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | 委托 delegate、Action、Func | ✅ |
| W1D2 | 事件 event、EventHandler | ✅ |
| W1D3 | Lambda表达式 | ✅ |
| W1D4 | LINQ：Where/Select/OrderBy/GroupBy | ✅ |
| W1D5 | LINQ实战：List筛选排序练习 | ⬜ |
| W1D6-7 | 周末：用LINQ做数据筛选小工具 | ⬜ |
| W2D1 | 文件读写：File.ReadAllText/WriteAllText | ⬜ |
| W2D2 | StreamReader/StreamWriter 逐行读写 | ⬜ |
| W2D3 | JSON序列化/反序列化（Newtonsoft.Json） | ⬜ |
| W2D4 | XML读写 | ⬜ |
| W2D5 | 配置面板保存/加载JSON | ⬜ |
| W2D6-7 | 周末：可保存配置的参数面板 | ⬜ |
| W3D1 | Thread 基础、前台/后台线程 | ⬜ |
| W3D2 | ThreadPool 线程池 | ⬜ |
| W3D3 | Task.Run()、Task.Factory | ⬜ |
| W3D4 | async/await 异步编程 | ⬜ |
| W3D5 | CancellationToken 取消任务 | ⬜ |
| W3D6-7 | 周末：多线程模拟采集+UI刷新Demo | ⬜ |
| W4D1 | lock、Monitor 线程安全 | ⬜ |
| W4D2 | ConcurrentQueue 生产者-消费者 | ⬜ |
| W4D3 | Invoke/BeginInvoke 跨线程更新UI | ⬜ |
| W4D4 | SynchronizationContext + async/await UI更新 | ⬜ |
| W4D5 | 三种跨线程方案对比：Invoke/BeginInvoke/SyncContext | ⬜ |
| W4D6-7 | 周末：后台多线程采集+UI不卡的综合练习 | ⬜ |

---

## 阶段二：SQL Server + Dapper + EF Core（5周）
### 状态：pending

> 覆盖：SQL Server、MySQL概念、Dapper、EF Core、DataGridView、EPPlus导出

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | 安装SQL Server Express + SSMS | ⬜ |
| W1D2 | 数据库/表/行/列、主键、外键、索引 | ⬜ |
| W1D3 | 数据类型、IDENTITY、约束 | ⬜ |
| W1D4 | SSMS建库建表（DeviceLog/AlarmHistory/Recipe三张表） | ⬜ |
| W1D5 | 手动插入20条模拟数据 | ⬜ |
| W1D6-7 | 周末：设备监控数据库设计（ChatGPT建议的表结构） | ⬜ |
| W2D1 | INSERT INTO 增 | ⬜ |
| W2D2 | UPDATE/DELETE 改删 | ⬜ |
| W2D3 | SELECT + WHERE + ORDER BY 查 | ⬜ |
| W2D4 | JOIN 联表查询 | ⬜ |
| W2D5 | GROUP BY + 聚合函数 统计 | ⬜ |
| W2D6-7 | 周末：SQL综合练习 | ⬜ |
| W3D1 | SqlConnection + SqlCommand | ⬜ |
| W3D2 | 参数化查询（@参数）防注入 | ⬜ |
| W3D3 | SqlDataReader 逐行读 | ⬜ |
| W3D4 | DataTable + SqlDataAdapter | ⬜ |
| W3D5 | DataGridView绑定 + 增删改 | ⬜ |
| W3D6-7 | 周末：C#数据库CRUD小工具 | ⬜ |
| W4D1 | 事务 Transaction | ⬜ |
| W4D2 | 批量写入 Bulk Insert（工业高频采集核心） | ⬜ |
| W4D3 | 索引优化 + 查询性能对比 | ⬜ |
| W4D4 | using 自动释放 + 连接字符串App.config | ⬜ |
| W4D5 | Windows认证 vs SQL认证 + 防火墙1433 | ⬜ |
| W4D6-7 | 周末：连接管理 + MySQL概念认知 | ⬜ |
| W5D1 | NuGet：Dapper | ⬜ |
| W5D2 | Dapper Query/Execute | ⬜ |
| W5D3 | Dapper 参数化 + 事务 | ⬜ |
| W5D4 | EF Core 概念 + DbContext | ⬜ |
| W5D5 | EF Core Code First 建表 | ⬜ |
| W5D6-7 | 周末：Dapper vs EF Core vs 原生SQL 对比 + EPPlus导出Excel | ⬜ |

---

## 阶段三：工业通信（8周）
### 状态：pending

> 覆盖：TCP/UDP/Socket、SerialPort、Modbus TCP/RTU、S7 PLC、OPC UA概念
> 工具：Wireshark 抓包分析

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | TCP/IP基础概念、三次握手 | ⬜ |
| W1D2 | Socket类、IPAddress、IPEndPoint | ⬜ |
| W1D3 | Connect + Send | ⬜ |
| W1D4 | Receive + 编码转换 | ⬜ |
| W1D5 | BitConverter Hex显示 | ⬜ |
| W1D6-7 | 周末：配合NetAssist，TCP双向收发工具 | ⬜ |
| W2D1 | UDP通信（UdpClient） | ⬜ |
| W2D2 | 粘包拆包问题 + 解决 | ⬜ |
| W2D3 | 心跳机制设计 | ⬜ |
| W2D4 | 断线自动重连 | ⬜ |
| W2D5 | try-catch + 异常分类 | ⬜ |
| W2D6-7 | 周末：TCP客户端（心跳+重连+不崩） | ⬜ |
| W3D1 | SerialPort类、GetPortNames() | ⬜ |
| W3D2 | 波特率/数据位/停止位/校验位 | ⬜ |
| W3D3 | DataReceived事件 | ⬜ |
| W3D4 | RS232 vs RS485 区别 | ⬜ |
| W3D5 | 配合VSPD串口收发 | ⬜ |
| W3D6-7 | 周末：串口调试工具 | ⬜ |
| W4D1 | Modbus协议理论（4种存储区） | ⬜ |
| W4D2 | 功能码01-06手动测试 | ⬜ |
| W4D3 | 功能码15-16 + 手写报文解析 | ⬜ |
| W4D4 | 站号+寄存器地址 | ⬜ |
| W4D5 | CAS Modbus Scanner + Wireshark抓包观察 | ⬜ |
| W4D6-7 | 周末：Modbus Slave搭环境+手写报文验证 | ⬜ |
| W5D1 | NuGet：FluentModbus | ⬜ |
| W5D2 | ModbusTcpClient 连接+读写 | ⬜ |
| W5D3 | ModbusRtuClient 串口连接 | ⬜ |
| W5D4 | 写寄存器/写线圈 | ⬜ |
| W5D5 | TCP vs RTU帧格式对比 | ⬜ |
| W5D6-7 | 周末：双模式Modbus读写工具 | ⬜ |
| W6D1 | 大小端概念 + 四种排列 | ⬜ |
| W6D2 | BitConverter 字节交换 | ⬜ |
| W6D3 | Float/Int32还原 | ⬜ |
| W6D4 | 通用字节序工具方法 | ⬜ |
| W6D5 | 多设备轮询设计 | ⬜ |
| W6D6-7 | 周末：字节序工具类 + 测试 | ⬜ |
| W7D1 | 西门子S7协议概念 + PLC数据区映射 | ⬜ |
| W7D2 | NuGet：S7.Net | ⬜ |
| W7D3 | S7.Net 读DB块（Bool/Int/Real） | ⬜ |
| W7D4 | S7.Net 写DB块 + 启停控制 | ⬜ |
| W7D5 | S7 vs Modbus 对比 | ⬜ |
| W7D6-7 | 周末：PLCSIM Advanced模拟+S7.Net联调 | ⬜ |
| W8D1 | OPC UA 概念 | ⬜ |
| W8D2 | OPC UA vs Modbus vs S7 对比 | ⬜ |
| W8D3 | EtherCAT/运动控制概念（仅了解） | ⬜ |
| W8D4 | 机器视觉概念（Halcon/VisionPro，仅了解） | ⬜ |
| W8D5 | MES对接概念（HTTP/API/WebService/MQTT） | ⬜ |
| W8D6-7 | 周末：工业通信全景复习 | ⬜ |

---

## 阶段四：WPF + MVVM + 项目实战（8周）
### 状态：pending

> 覆盖：XAML、Binding、MVVM、CommunityToolkit.Mvvm、LiveCharts、HandyControl
> 原则：只学到够用——工业界面不需要毛玻璃和复杂动画（ChatGPT+Gemini共识）

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | WPF vs WinForms 思维转变 | ⬜ |
| W1D2 | XAML语法 + Grid布局 | ⬜ |
| W1D3 | StackPanel/DockPanel/WrapPanel | ⬜ |
| W1D4 | Margin/Padding/对齐 | ⬜ |
| W1D5 | 资源字典 ResourceDictionary | ⬜ |
| W1D6-7 | 周末：自适应工业监控主窗体 | ⬜ |
| W2D1 | TextBlock/TextBox/Button/ComboBox WPF版 | ⬜ |
| W2D2 | DataGrid、ListView | ⬜ |
| W2D3 | Style样式 + Trigger触发器 | ⬜ |
| W2D4 | WPF重写设备参数配置面板 | ⬜ |
| W2D5 | WPF重写Modbus通信面板 | ⬜ |
| W2D6-7 | 周末：WPF版参数配置+通信面板整合 | ⬜ |
| W3D1 | {Binding} 基础语法 | ⬜ |
| W3D2 | DataContext 数据上下文 | ⬜ |
| W3D3 | INotifyPropertyChanged | ⬜ |
| W3D4 | IValueConverter 值转换 | ⬜ |
| W3D5 | 零事件代码的绑定表单 | ⬜ |
| W3D6-7 | 周末：绑定综合练习 | ⬜ |
| W4D1 | MVVM概念：M-V-VM三层 | ⬜ |
| W4D2 | ICommand + RelayCommand | ⬜ |
| W4D3 | CommunityToolkit.Mvvm入门 | ⬜ |
| W4D4 | ObservableObject + RelayCommand | ⬜ |
| W4D5 | 消息机制 Messenger | ⬜ |
| W4D6-7 | 周末：Modbus采集工具MVVM重构 | ⬜ |
| W5D1 | HandyControl引入 | ⬜ |
| W5D2 | ToggleSwitch/Loading/Growl | ⬜ |
| W5D3 | 深色/浅色主题 | ⬜ |
| W5D4 | 工业界面美化（指示灯/设备面板） | ⬜ |
| W5D6-7 | 周末：界面全面美化 | ⬜ |
| W6D1 | LiveCharts.Wpf 引入 | ⬜ |
| W6D2 | CartesianChart + LineSeries | ⬜ |
| W6D3 | 多曲线 + X轴时间格式 | ⬜ |
| W6D4 | 滚动刷新 + 缩放 | ⬜ |
| W6D5 | 实时曲线 + 历史回放 | ⬜ |
| W6D6-7 | 周末：模拟数据实时看板 | ⬜ |
| W7D1 | Frame + Page 导航 | ⬜ |
| W7D2 | 左侧菜单 + 页面切换 | ⬜ |
| W7D3 | 用户控件 UserControl | ⬜ |
| W7D4 | Prism 框架概念（仅了解，半天） | ⬜ |
| W7D5 | 多页面导航系统整合 | ⬜ |
| W7D6-7 | 周末：完整导航系统测试 | ⬜ |
| W8 | 简历王牌项目开发（见下方） | ⬜ |

---

## 简历王牌项目：工业设备监控系统

| 模块 | 技术点 | 对应JD |
|------|--------|--------|
| 设备通信 | Modbus TCP/RTU + S7 PLC | 工业通信 |
| 实时监控 | WPF + MVVM + LiveCharts实时曲线 | WPF开发经验 |
| 数据管理 | SQL Server + Dapper + 历史查询 + 批量写入 | 数据库开发 |
| 报警管理 | 阈值判断 + 实时弹窗 + AlarmHistory表 | 报警管理 |
| 用户权限 | 登录 + 角色权限（管理员/操作员） | 用户权限 |
| 日志系统 | NLog 文件日志 + 数据库日志 + Wireshark抓包 | 日志系统 |
| 配置管理 | JSON配置文件 + 界面配置 | 配置管理 |
| Excel导出 | EPPlus/ClosedXML 导出历史数据+报警记录 | Excel导出 |
| 异常处理 | 断线重连 + 心跳机制 + 超时处理 | 通信稳定性 |
| 安装部署 | Advanced Installer 打包成安装程序 | 工程化 |

---

## 打磨阶段（2月·4周）

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| 1-2 | GitHub：README + 截图 + 架构图 + 演示视频 | ⬜ |
| 3-4 | 简历撰写（3个项目：采集工具→PLC监控→WPF系统） | ⬜ |
| 5 | 原型图工具认知（Axure/墨刀，半天） | ⬜ |
| 6 | 安装包制作（Advanced Installer，半天） | ⬜ |
| 7-8 | **面试题库**（见下方） | ⬜ |
| 9-10 | 模拟面试（自我介绍2min + 项目介绍5min，录音反复练） | ⬜ |

### 面试题库（四家AI共识提炼）

| 类别 | 高频题 |
|------|--------|
| 多线程 | 跨线程更新UI有几种方案？各自适用场景？死锁怎么产生、怎么规避？ |
| 通信 | 设备断线怎么检测？重连策略怎么设计？TCP粘包拆包怎么处理？ |
| Modbus | Modbus TCP和RTU的区别？功能码03/06/16的差异？大小端字节序怎么转换？ |
| PLC | S7协议和Modbus区别？PLC数据区映射I/Q/M/DB块？读到乱码怎么排查？ |
| 数据库 | SQL Server索引优化策略？批量写入和单条写入性能差多少？事务隔离级别？ |
| WPF/MVVM | INotifyPropertyChanged原理？ICommand和RelayCommand的区别？Binding Mode？ |
| 现场经验 | 遇到过最难的通信问题是什么？怎么排查的？上位机程序上线后崩溃怎么定位？ |

---

## 各阶段技术栈对照JD

| JD高频要求 | 阶段 | 掌握程度 |
|------------|:--:|:--:|
| C# + .NET | 全程 | 熟练 |
| WinForm + WPF | 全程 | 双框架 |
| 委托/事件/Lambda/LINQ | 一 | 熟练 |
| 多线程/async-await/三种UI同步方案 | 一 | 熟练 |
| SQL Server + MySQL | 二 | SQL Server熟练，MySQL了解 |
| Dapper + EF Core | 二 | Dapper熟练，EF Core会用 |
| Socket/TCP/UDP + 粘包/心跳/重连 | 三 | 熟练 |
| SerialPort/RS232/RS485 | 三 | 熟练 |
| Modbus TCP/RTU + 手写报文 | 三 | 熟练 |
| S7.Net PLC通信 + 数据区映射 | 三 | 会用 |
| OPC UA | 三 | 概念+了解 |
| MVVM/CommunityToolkit.Mvvm | 四 | 熟练 |
| WPF数据绑定/DataGrid/UserControl | 四 | 够用（不深挖样式动画） |
| LiveCharts实时曲线 | 四 | 会用 |
| Git版本控制 | 零 | 全程使用 |
| Excel导出（EPPlus/ClosedXML） | 二/项目 | 会用 |
| Wireshark抓包分析 | 三 | 会用 |
| SunnyUI工业控件库 | 一 | 会用 |
| 安装包制作 | 打磨 | 会用 |

---

## 禁止事项
- 禁止 `CheckForIllegalCrossThreadCalls = false`
- 禁止简历写 SQLite
- 禁止拖控件
- 禁止 WPF 深挖 ControlTemplate/动画/毛玻璃——够用即停
- 禁止 WinForm 原生控件自定义样式——用 SunnyUI 替代

## 决策记录（四家AI交叉验证后终版）

| 日期 | 决策 | 数据依据 |
|------|------|------|
| 5/30 | SQL Server为主，MySQL概念 | JD数据+三家AI共识 |
| 5/30 | 拒绝SQLite（4家AI反复推） | 成都JD 0条提及SQLite |
| 5/30 | S7.Net实操（非仅概念） | 学习指南+ChatGPT共识 |
| 5/30 | WinForm+WPF双修 | 调研报告+四家共识 |
| 5/30 | 砍WPF ControlTemplate/动画 | ChatGPT+Gemini共识：工业不需要 |
| 5/30 | 引入SunnyUI工业控件库 | 豆包v2独到建议 |
| 5/30 | Wireshark抓包进工具链 | 豆包v2+Gemini共识 |
| 5/30 | 三种跨线程方案对比 | 豆包v2：Invoke/SyncContext/async-await |
| 5/30 | 面试题库按类别重构 | 豆包v2+ChatGPT共识 |
| 5/30 | 只用西门子S7，不做三菱/欧姆龙 | ChatGPT共识：初学者不要贪多 |
