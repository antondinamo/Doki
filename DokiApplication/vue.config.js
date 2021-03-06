module.exports = {
  baseUrl: '',
  assetsDir: 'asserts',
  outputDir: '../DokiAPI/wwwroot',
  runtimeCompiler: undefined,
  productionSourceMap: undefined,
  parallel: undefined,
  css: undefined,

  devServer: {
    proxy: {
      '/api': {
        target: 'http://localhost:5000',
        ws: true,
        changeOrigin: true
      }
    }
  },

  lintOnSave: undefined
};
