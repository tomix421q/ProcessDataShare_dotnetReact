import configDev from './config.dev.json'
import configProd from './config.prod.json'

function loadConfig() {
    // eslint-disable-next-line no-undef
    if(process.env.NODE_ENV === 'production'){
        return configProd
    } else {
        return configDev
    }

}

export default loadConfig;