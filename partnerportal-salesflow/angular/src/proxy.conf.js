const PROXY_CONFIG = [
  {
    context: [
      "/api/weatherforecast",
      "/api/TodoItems",
    ],
    target: "https://localhost:7184",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
