import WebHost from 'netmodular-module-admin'
import config from './config'
import Blog from './index'

// 注入模块
WebHost.registerModule(Blog)

// 启动
WebHost.start(config)
