const express = require('express')
const httpProxy = require('http-proxy')
const apiProxy = httpProxy.createProxyServer()

const app = express()
const path = require('path')

const PORT = 3009

app.all('*', (req, res) => {
  apiProxy.web(req, res, { target: 'http://localhost:5147' })
})

app.use(express.static(path.join(__dirname, 'dist')))

app.listen(PORT, () => {
  console.log(`Server bezi na porte => ${PORT}`)
})
