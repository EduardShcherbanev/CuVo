import { GET_VOCABULARY_SUCCESS, GET_VOCABULARY_ERROR } from './vocabularyConstants.jsx'
import "isomorphic-fetch"

export function receiveVocabulary(data) {
    return {
        type: GET_VOCABULARY_SUCCESS,
        payload: data
    };
}

export function errorReceive(err) {
    return {
        type: GET_VOCABULARY_ERROR,
        payload: err
    };
}

export function getVocabulary() {
    return (dispatch) => {
        fetch(constants.getvocabulary)
            .then((response) => {
                return response.json();
            }).then((data) => {
                dispatch(receiveVocabulary(data));
            }).catch((ex) => {
                dispatch(errorReceive(ex));
            });
    };
}